namespace UnitTesting
{
    public interface IUserManager
    {
        bool Login(string userName,string password);
    }

    public class UserManager : IUserManager
    {
        public bool Login(string userName,string password)
        {
            if (userName == "admin" && password == "123")
                return true;
            else
                return false;
            
        }
    }
}