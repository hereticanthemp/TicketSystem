using TicketSystem.Models;

namespace TicketSystem.Services
{
    public class MockUserService : IUserService
    {
        public MockUserService()
        {
            _users = new List<User>
            {
                new User { Id = 0, Roles = Roles.Admin, Serial="0000", Username = "Adam" },
                new User { Id = 1, Roles = Roles.QA, Serial="0001", Username = "Queenie" },
                new User { Id = 2, Roles = Roles.RD, Serial="0002", Username = "Richard" },
                new User { Id = 3, Roles = Roles.RD, Serial="0003", Username = "Thanox", Suspend=true },
            };
        }

        private readonly List<User> _users;


        public void AddUser(User user)
        {
            var exist = _users.Exists(u => u.Username == user.Username || u.Serial == user.Serial);
            if (exist) throw new Exception("duplicate user");
            user.Id = _users.Last().Id + 1;
            _users.Add(user);
        }

        public void ModifyUser(User user)
        {
            var exist = _users.Find(u => u.Id == user.Id);
            if (exist == null) return;
            foreach (var prop in user.GetType().GetProperties())
            {
                var val = prop.GetValue(user, null);
                if (val != null)
                {
                    prop.SetValue(exist, val);
                }
            }
        }

        public void SuspendUser(User user)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetUsers()
        {
            return _users;
        }
    }
}
