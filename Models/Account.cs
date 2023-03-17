namespace _10.Models
{
    
    public class Account
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string Phone { get; set; }

        public static List<Order> Orders = null;
        public user user { get; set; }
    }
   public enum user
    {
        admin =1,
        user=2
    }
    public class Login
    {
        public int? loginId { get; set; }
    }
}
