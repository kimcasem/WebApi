using WebApi.Domain.Entities;

namespace WebApi.Contracts
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUserById(int userId);
        void AddNewUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
