using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Models
{
    public class User
    {
        /// <summary>
        /// Auto Increment
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        public string? Serial { get; set; }

        public Roles? Roles { get; set; }

        public string? Username { get; set; }

        public bool? Suspend { get; set; } = false;
    }
}
