using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Address.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Address
{
    public class PmAddressService : PmBaseService, IPmAddressService
    {
        public PmAddressService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmAddressResponse?> CreateAddressAsync(string customerId, PmCreateAddressRequest request)
        {
            var url = string.Format(PmEndpoints.Addresses.Base, customerId);
            return await PostAsync<PmAddressResponse, PmCreateAddressRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmAddressResponse?> GetAddressAsync(string customerId, string addressId)
        {
            var url = string.Format(PmEndpoints.Addresses.Get, customerId, addressId);
            return await GetAsync<PmAddressResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmListAddressesResponse?> ListAddressesAsync(string customerId, int? page = null,
            int? size = null)
        {
            var url = string.Format(PmEndpoints.Addresses.Base, customerId);
            var queryParameters = new List<string>();
            if (page.HasValue) queryParameters.Add($"page={page.Value}");
            if (size.HasValue) queryParameters.Add($"size={size.Value}");

            if (queryParameters.Count > 0) url += "?" + string.Join("&", queryParameters);

            return await GetAsync<PmListAddressesResponse>(url);
        }

        /// <inheritdoc />
        public async Task<PmAddressResponse?> UpdateAddressAsync(string customerId, string addressId,
            PmUpdateAddressRequest request)
        {
            var url = string.Format(PmEndpoints.Addresses.Update, customerId, addressId);
            return await PutAsync<PmAddressResponse, PmUpdateAddressRequest>(url, request);
        }

        /// <inheritdoc />
        public async Task<PmAddressResponse?> DeleteAddressAsync(string customerId, string addressId)
        {
            var url = string.Format(PmEndpoints.Addresses.Delete, customerId, addressId);
            return await DeleteAsync<PmAddressResponse>(url);
        }
    }
}