//using APIDemo.Controllers.Models;
using APIDemo.Models;
using System.Xml.Linq;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        private static Ticket ticket;

        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                   new Ticket{ Id= 1, BookedFor = "Movie1",Price=5000,Qty=2},
                   new Ticket{ Id= 2, BookedFor = "Movie2",Price=4000,Qty=3},
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

        
    }
}