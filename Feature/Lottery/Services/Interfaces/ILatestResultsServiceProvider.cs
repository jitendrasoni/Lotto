using Business.Dto;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface ILatestResultsServiceProvider
    {
        Task<LatestResultsApiResponse> GetLatestResults(LatestResultsRequest request);
    }
}
