using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Exceptions;

namespace Berdsk.Sdk.PagarMe.V5.Services
{
    public abstract class PmBaseService
    {
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        protected readonly HttpClient HttpClient;

        protected PmBaseService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected async Task<TResponse?> PostAsync<TResponse, TRequest>(string url, TRequest request,
            IDictionary<string, string>? headers = null) where TResponse : class
        {
            using var httpRequest = new HttpRequestMessage(HttpMethod.Post, url);
            httpRequest.Content = JsonContent.Create(request, options: JsonOptions);

            if (headers != null)
                foreach (var header in headers)
                    httpRequest.Headers.Add(header.Key, header.Value);

            var response = await HttpClient.SendAsync(httpRequest);
            return await HandleResponseAsync<TResponse>(response);
        }

        protected async Task<T?> GetAsync<T>(string url) where T : class
        {
            var response = await HttpClient.GetAsync(url);
            return await HandleResponseAsync<T>(response);
        }

        protected async Task<TResponse?> PutAsync<TResponse, TRequest>(string url, TRequest request)
            where TResponse : class
        {
            var response = await HttpClient.PutAsJsonAsync(url, request, JsonOptions);
            return await HandleResponseAsync<TResponse>(response);
        }

        protected async Task<T?> DeleteAsync<T>(string url, object? request = null) where T : class
        {
            var response = request == null
                ? await HttpClient.DeleteAsync(url)
                : await HttpClient.SendAsync(new HttpRequestMessage(HttpMethod.Delete, url)
                {
                    Content = JsonContent.Create(request, options: JsonOptions)
                });

            return await HandleResponseAsync<T>(response);
        }

        protected async Task<TResponse?> PatchAsync<TResponse, TRequest>(string url, TRequest request)
            where TResponse : class
        {
            var response = await HttpClient.PatchAsJsonAsync(url, request, JsonOptions);
            return await HandleResponseAsync<TResponse>(response);
        }

        private static async Task<T?> HandleResponseAsync<T>(HttpResponseMessage response) where T : class
        {
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NoContent)
                    return null;
                return await response.Content.ReadFromJsonAsync<T>(JsonOptions);
            }

            var rawBody = await response.Content.ReadAsStringAsync();
            PmErrorResponse? errorResponse = null;
            try
            {
                errorResponse = JsonSerializer.Deserialize<PmErrorResponse>(rawBody, JsonOptions);
            }
            catch
            {
                // Ignora erro de desserialização, o rawBody será passado para a exception
            }

            throw response.StatusCode switch
            {
                HttpStatusCode.BadRequest => new PmBadRequestException(errorResponse, rawBody),
                HttpStatusCode.Unauthorized => new PmUnauthorizedException(errorResponse, rawBody),
                HttpStatusCode.Forbidden => new PmForbiddenException(errorResponse, rawBody),
                HttpStatusCode.NotFound => new PmNotFoundException(errorResponse, rawBody),
                HttpStatusCode.PreconditionFailed => new PmPreconditionFailedException(errorResponse, rawBody),
                HttpStatusCode.UnprocessableEntity => new PmValidationException(errorResponse, rawBody),
                HttpStatusCode.TooManyRequests => new PmTooManyRequestsException(errorResponse, rawBody),
                HttpStatusCode.InternalServerError => new PmInternalServerErrorException(errorResponse, rawBody),
                _ => new PagarMeException(response.StatusCode, errorResponse, rawBody)
            };
        }
    }
}