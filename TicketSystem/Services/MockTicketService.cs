using TicketSystem.Models;

namespace TicketSystem.Services
{
    public class MockTicketService : ITicketService
    {
        private readonly List<Ticket> _tickets;
        public MockTicketService()
        {
            _tickets = new List<Ticket>
            {
                new Ticket() { Id = 1, Deleted =false, Description = "Normal", Summary = "Test1", Creator = new User{ Username="QA"}, CreateTime = new DateTime(2022,1,1)},
                new Ticket() { Id = 2, Deleted =false, Description = "Resolved", Summary = "Test2", Creator = new User{ Username="QA"}, CreateTime = new DateTime(2022,1,2), Resolved= true},
                new Ticket() { Id = 3, Deleted =true, Description = "Deleted Item", Summary = "Test3", Creator = new User{ Username="QA"}, CreateTime = new DateTime(2022,1,3)},
            };
        }

        public void CreateTicket(Ticket ticket)
        {
            ticket.CreateTime = DateTime.Now;
            ticket.UpdateTime = ticket.CreateTime;
            ticket.Id = _tickets.Last().Id + 1;
            _tickets.Add(ticket);
        }

        public void DeleteTicket(Ticket ticket)
        {
            var index = _tickets.FindIndex(t => t.Id == ticket.Id);
            if (index > -1)
            {
                _tickets[index].Deleted = true;
                _tickets[index].UpdateTime = DateTime.Now;
            }
        }

        public void EditTicket(Ticket ticket)
        {
            var index = _tickets.FindIndex(t => t.Id == ticket.Id);
            if (index > -1)
            {
                _tickets[index] = ticket;
                _tickets[index].UpdateTime = DateTime.Now;
            }
        }

        public ICollection<Ticket> GetTickets(TicketConditionParam param)
        {
            var resp = _tickets.AsQueryable();
            if (!param.IncludeDeleted)
            {
                resp = resp.Where(t => !t.Deleted);
            }
            if (!param.IncludeResolved)
            {
                resp = resp.Where(t => !t.Resolved);
            }
            if (param.StartTime != null)
            {
                resp = resp.Where(t => t.CreateTime >= param.StartTime);
            }
            if (param.EndTime != null)
            {
                resp = resp.Where(t => t.CreateTime <= param.EndTime);
            }
            return resp.ToList();
        }

        public void ResolveTicket(Ticket ticket)
        {
            var index = _tickets.FindIndex(t => t.Id == ticket.Id);
            if (index > -1)
            {
                _tickets[index].Resolved = true;
                _tickets[index].Resolver = ticket.Resolver;
                _tickets[index].UpdateTime = DateTime.Now;
            }
        }
    }
}
