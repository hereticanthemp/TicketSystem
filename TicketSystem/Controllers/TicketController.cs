using Microsoft.AspNetCore.Mvc;
using TicketSystem.Models;
using TicketSystem.Services;

namespace TicketSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TicketController : ControllerBase
    {
        ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost]
        public void CreateTicket(Ticket ticket)
        {
            _ticketService.CreateTicket(ticket);
        }

        [HttpPost]
        public void EditTicket(Ticket ticket)
        {
            _ticketService.EditTicket(ticket);
        }

        [HttpPost]
        public void DeleteTicket(Ticket ticket)
        {
            _ticketService.DeleteTicket(ticket);
        }

        [HttpPost]
        public void ResolveTicket(Ticket ticket)
        {
            _ticketService.ResolveTicket(ticket);
        }

        [HttpPost]
        public ICollection<Ticket> GetTickets(TicketConditionParam param)
        {
            return _ticketService.GetTickets(param);
        }
    }
}
