using System.Net.Http;
using System.Threading.Tasks;
using Business.Dto;

namespace Business.Services
{
    public class LatestResultsServiceProvider : BaseApiServiceProvider, ILatestResultsServiceProvider
    {
        public LatestResultsServiceProvider(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<LatestResultsApiResponse> GetLatestResults(LatestResultsRequest request)
        {
            return await PostAsync<LatestResultsApiResponse>("/sales/vmax/web/data/lotto/latestresults", request).ConfigureAwait(false);
        }
    }
}
