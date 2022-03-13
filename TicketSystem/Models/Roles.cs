using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Models
{
    [Flags]
    public enum Roles
    {
        Unknown = 0,
        QA = 1,
        RD = 2,
        PM = 4,


        /// <summary>
        /// Administrator
        /// </summary>
        Admin = 8,
    }
}