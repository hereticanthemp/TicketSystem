using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public string? Summary { get; set; }

        public string? Description { get; set; }

        public bool Resolved { get; set; } = false;

        /// <summary>
        /// Mark as Deleted
        /// </summary>
        public bool Deleted { get; set; } = false;

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime ResolveTime { get; set; }

        public User? Creator { get; set; }

        public User? Resolver { get; set; }

        public int Severity { get; set; }

        public int Priority { get; set; }

        public TicketType Type { get; set; }
    }

    public enum TicketType
    {
        Bug = 1,
        FeatureRequest = 2
    }
}
