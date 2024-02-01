using CaseAPI.Core.Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseAPI.Entities.Entity
{
    [Table("Products")]
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
