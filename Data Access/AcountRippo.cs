using _10.Models;
namespace _10.Data_Access
{
    public class AcountRippo
    {
        
       
        public static List<Account> Accounts = new List<Account>
        {
            new Account{Id =1,Name="admin",Email="admin",Password="admin",Phone="111",user=user.admin},
            new Account{Id =2,Name="ashkan",Email="user",Password="user",Phone="222",user=user.user},
            new Account{Id =3,Name="person",Email="person",Password="person",Phone="333",user=user.user}
        };
        
        public List<Account> GetList()
        {
            return Accounts;
        }
        public static Account currentuser;
       
        
    }

}
