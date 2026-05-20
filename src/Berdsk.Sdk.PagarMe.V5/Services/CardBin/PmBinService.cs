using System.Net.Http;
using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.CardBin.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.CardBin
{
    public class PmBinService : PmBaseService, IPmBinService
    {
        public PmBinService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PmBinResponse?> GetBinAsync(string bin)
        {
            var url = string.Format(PmEndpoints.CardBin.Base, bin);
            return await GetAsync<PmBinResponse>(url);
        }
    }
}