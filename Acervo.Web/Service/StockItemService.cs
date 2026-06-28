using Acervo.Web.Endpoints.StockItem;
using System.Net.Http.Json;

namespace Acervo.Web.Service
{
    public class StockItemService(HttpClient http)
    {
        public record StockItemDto(long Id, long BookId, decimal Price, int Quantity);

        public async Task<List<StockItemDto>> GetAll() =>
            await http.GetFromJsonAsync<List<StockItemDto>>(StockItemEndpoints.GetAll()) ?? [];
    }
}
