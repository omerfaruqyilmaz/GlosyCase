namespace CaseAPI.Entities.Dto.Product.Request
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
