using System.Net.Sockets;
using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Service
{
    public class TicketService
    {
        static List<Tickets> Tickets { get; }
        static int nextId = 3;
        private static Tickets ticket;

        static TicketService()
        {
            Tickets = new List<Tickets>
            {
                   new Tickets{ Id= 1, Name = "Movie1",Price=5000},
                   new Tickets{ Id= 2, Name = "Movie2",Price=4000},
            };
        }

        public static List<Tickets> GetAll() => Tickets;

        public static Tickets? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

        public static void Add(Tickets Ticket)
        {
            Ticket.Id = nextId++;
            Tickets.Add(Ticket);
        }

        public static void Delete(int id)
        {
            var Ticket = Get(id);
            if (Ticket is null)
                return;

            Tickets.Remove(Ticket);
        }

        public static void Update(Tickets Ticket)
        {
            var index = Tickets.FindIndex(t => t.Id == Ticket.Id);
            if (index == -1)
                return;

            Tickets[index] = ticket;
        }
    }
}