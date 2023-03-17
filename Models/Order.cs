namespace _10.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public List<int> Productid { get; set; }
   
    }
}
