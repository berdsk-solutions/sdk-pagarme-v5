using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net.Http;
using Berdsk.Sdk.PagarMe.V5.Services.Address;
using Berdsk.Sdk.PagarMe.V5.Services.Cards;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Customer
{
    public class PmCustomerService : PmBaseService, IPmCustomerService
    {
        public PmCustomerService(HttpClient httpClient) : base(httpClient)
        {
            Cards = new PmCardService(httpClient);
            Addresses = new PmAddressService(httpClient);
        }

        /// <inheritdoc />
        public IPmCardService Cards { get; }

        /// <inheritdoc />
        public IPmAddressService Addresses { get; }

        /// <inheritdoc />
        public async Task<PmCustomerResponse?> CreateCustomerAsync(PmCreateCustomerRequest request)
        {
            return await PostAsync<PmCustomerResponse, PmCreateCustomerRequest>(PmEndpoints.Customers.Base, request);
        }

        /// <inheritdoc />
        public async Task<PmCustomerResponse?> GetCustomerAsync(string customerId)
        {
            var url = string.Format(PmEndpoints.Customers.Get, customerId);
            return await GetAsync<PmCustomerResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmCustomerResponse?> UpdateCustomerAsync(string customerId, PmUpdateCustomerRequest request)
        {
            var url = string.Format(PmEndpoints.Customers.Update, customerId);
            return await PutAsync<PmCustomerResponse, PmUpdateCustomerRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmListCustomersResponse?> ListCustomersAsync(string? name = null, string? email = null,
            string? document = null, string? gender = null, string? code = null, int? page = null, int? size = null)
        {
            var queryParameters = new List<string>();
            if (!string.IsNullOrEmpty(name)) queryParameters.Add($"name={Uri.EscapeDataString(name)}");
            if (!string.IsNullOrEmpty(email)) queryParameters.Add($"email={Uri.EscapeDataString(email)}");
            if (!string.IsNullOrEmpty(document)) queryParameters.Add($"document={Uri.EscapeDataString(document)}");
            if (!string.IsNullOrEmpty(gender)) queryParameters.Add($"gender={Uri.EscapeDataString(gender)}");
            if (!string.IsNullOrEmpty(code)) queryParameters.Add($"code={Uri.EscapeDataString(code)}");
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            var url = PmEndpoints.Customers.Base;
            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListCustomersResponse>(url);
        }
    }
}




