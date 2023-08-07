using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login_App.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal BasePrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TaxRate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TaxAmount { get; set; }


        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalAmount { get; set; }
        
    }
}
