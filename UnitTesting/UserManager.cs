namespace UnitTesting
{
    public class UserManager
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