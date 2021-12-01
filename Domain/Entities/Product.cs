using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Domain.Entities
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Rate { get; set; }
    }
}