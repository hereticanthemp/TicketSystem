namespace TicketSystem.Models
{
    public class TicketConditionParam
    {
        public bool IncludeDeleted { get; set; }
        public bool IncludeResolved { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
