using TicketSystem.Models;

namespace TicketSystem.Services
{
    public interface IUserService
    {
        public ICollection<User> GetUsers();
        public void AddUser(User user);
        public void ModifyUser(User user);
        public void SuspendUser(User user);
    }
}
