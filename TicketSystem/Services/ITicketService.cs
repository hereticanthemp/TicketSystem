﻿using TicketSystem.Models;

namespace TicketSystem.Services
{
    public interface ITicketService
    {
        public void CreateTicket(Ticket ticket);

        public void EditTicket(Ticket ticket);

        public void DeleteTicket(Ticket ticket);

        public void ResolveTicket(Ticket ticket);
    }
}
