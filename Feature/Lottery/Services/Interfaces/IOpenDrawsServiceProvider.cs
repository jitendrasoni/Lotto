using Business.Dto;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IOpenDrawsServiceProvider
    {
        Task<OpenDrawsApiResponse> GetOpenDraws(OpenDrawsRequest request);
    }
}
