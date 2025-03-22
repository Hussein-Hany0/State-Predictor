using GraduationProject.App.Models;

namespace Predator.App.Repositories
{
    public interface IUserRepository
    {
        public bool IsAuthenticatedUser(string email, string password);

        public User GetUserByCredentials(string email, string password);

        public void CreateUser(User user);

        public bool CompareOldPasswordToCurrentPassword(int id, string oldPassword);

        public void UpdatePassword(int id, string newPassword);
    }
    public class UserRepository : IUserRepository
    {
        private PredatorContext _context;
        public UserRepository(PredatorContext context)
        {
            _context = context;
        }

        public bool CompareOldPasswordToCurrentPassword(int id, string oldPassword)
        {
            User? user = _context.Users.Find(id);

            return user.Password == oldPassword ? true : false;
        }

        public void CreateUser(User user)
        {
            //the _context will infer the table by knowing the type of the arguemnt passed.
            _context.Add(user);

            _context.SaveChanges();
        }

        public User GetUserByCredentials(string email, string password)
        {
            User? user = _context.Users.SingleOrDefault(user
                => user.Email == email && user.Password == password);

            return user;
        }

        public bool IsAuthenticatedUser(string email , string password)
        {
            User? user = _context.Users.SingleOrDefault(user
                => user.Email == email && user.Password == password);

            return user == null ? false : true;
        }

        public void UpdatePassword(int id, string newPassword)
        {
            User? user = _context.Users.Find(id);

            user.Password = newPassword;

            _context.SaveChanges();
        }
    }
}
