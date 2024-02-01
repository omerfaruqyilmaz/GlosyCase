using Newtonsoft.Json;

namespace CaseAPI.Entities.Dto.Product.Response
{
    public class ProductListResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
}
