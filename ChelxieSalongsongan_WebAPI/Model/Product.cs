using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstDatabaseApi.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")] // Add this line
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}