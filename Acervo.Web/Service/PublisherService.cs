using Acervo.Web.Endpoints.Publisher;
using System.Net.Http.Json;

namespace Acervo.Web.Service
{
    public class PublisherService(HttpClient http)
    {
        public record PublisherDto(long Id, string Name, string Country, string Website);

        public async Task<List<PublisherDto>> GetAll() =>
            await http.GetFromJsonAsync<List<PublisherDto>>(PublisherEndpoints.GetAll()) ?? [];
    }
}
