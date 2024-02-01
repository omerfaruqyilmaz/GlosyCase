namespace CaseAPI.Entities.Dto.Product.Request
{
    public class AddProductRequest
    {
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
