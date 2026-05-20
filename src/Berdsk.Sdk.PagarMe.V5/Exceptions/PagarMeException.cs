using System;
using System.Net;

namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Exceção base para erros retornados pela API Pagar.me.
    /// </summary>
    public class PagarMeException : Exception
    {
        public PagarMeException(HttpStatusCode statusCode, PmErrorResponse? errorResponse, string? rawBody = null)
            : base(errorResponse?.Message ?? $"PagarMe API error with status code {statusCode}")
        {
            StatusCode = statusCode;
            ErrorResponse = errorResponse;
            RawBody = rawBody;
        }

        public PagarMeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        ///     Código de status HTTP retornado.
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        ///     Objeto de resposta de erro detalhado.
        /// </summary>
        public PmErrorResponse? ErrorResponse { get; }

        /// <summary>
        ///     Corpo bruto da resposta em caso de erro.
        /// </summary>
        public string? RawBody { get; }
    }
}