using System.Net.Http;
using System.Threading.Tasks;
using Business.Dto;

namespace Business.Services
{
    public class OpenDrawsServiceProvider : BaseApiServiceProvider, IOpenDrawsServiceProvider
    {
        public OpenDrawsServiceProvider(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<OpenDrawsApiResponse> GetOpenDraws(OpenDrawsRequest request)
        {
            return await PostAsync<OpenDrawsApiResponse>("/sales/vmax/web/data/lotto/opendraws", request).ConfigureAwait(false);
        }
    }
}
