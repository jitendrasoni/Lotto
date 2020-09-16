using Business.Dto;
using Newtonsoft.Json;
using Lotto.Feature.Lottery.Dto.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace Business.Services
{
    public abstract class BaseApiServiceProvider
    {
        private readonly HttpClient _httpClient;

        public BaseApiServiceProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> PostAsync<T>(string apiEndpoint, IDrawRequest request)
        {
            try
            {
                var myContent = JsonConvert.SerializeObject(request);

                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);

                var response = await _httpClient.PostAsync(apiEndpoint, byteContent).ConfigureAwait(false);

                if (response.IsSuccessStatusCode == true)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    // log response
                    return default(T);
                }

            }
            catch (System.Exception)
            {
                //todo: log error here
                throw;
            }
        }
    }
}
