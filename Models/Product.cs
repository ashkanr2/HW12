using System.ComponentModel.DataAnnotations;

namespace _10.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Number { get; set; }
        public int? Number2 { get; set; } = 0;
        public decimal Price { get; set;}

       // public int [] PersonsId { get; set; }
        public int? PersonId { get; set;}
        
    }
}
