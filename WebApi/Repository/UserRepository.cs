using WebApi.Contracts;
using WebApi.Data;
using WebApi.Domain.Entities;

namespace WebApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(u => u.Id).ToList();
        }

        public User GetUserById(int userId)
        {
            return _context.Users.Where(u => u.Id == userId).FirstOrDefault();
        }

        public void AddNewUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            //var userExist = _context.Users.FirstOrDefault(u => u.Id == user.Id)
            _context.Update(user);
            _context.SaveChanges();
        }
        public void DeleteUser(int userId)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);

            if (user != null)
            {
                _context.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
