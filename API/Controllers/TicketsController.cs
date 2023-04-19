using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly StoreContext _context;
        public TicketsController(StoreContext context)
        {
            _context = context;

        }

        [HttpGet]

        public async Task<ActionResult<List<Ticket>>> GetTickets()
        {
            return await _context.Tickets.ToListAsync();
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<Ticket>> GetTicket(int id)
        {
            return await _context.Tickets.FindAsync(id);
        }

    }


}