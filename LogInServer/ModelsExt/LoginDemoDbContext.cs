namespace LogInServer.Models
{
    public partial class LoginDemoDbContext
    {
        public Models.User GetUserFromDB(string email)
        {
            Models.User user = this.Users.Where(u => u.Email == email).FirstOrDefault();
            return user;
        }
    }
}
