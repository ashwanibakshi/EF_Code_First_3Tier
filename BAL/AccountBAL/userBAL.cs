using ClassLibrary1;
using ClassLibrary1.Data_Model;
using DAL;
using DAL.Concrete;

namespace BAL.AccountBAL
{
    public static class userBAL
    {
       private static IRepository<User> userRepo = new Repository<User>();

       public static void AddUser(User u)
        {
            userRepo.Insert(u);
        }
	  
    }
}
