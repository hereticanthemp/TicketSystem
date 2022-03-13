using Microsoft.AspNetCore.Mvc;

namespace TicketSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TicketController : ControllerBase
    {
        [HttpPost]
        public void CreateTicket()
        {

        }
    }
}
