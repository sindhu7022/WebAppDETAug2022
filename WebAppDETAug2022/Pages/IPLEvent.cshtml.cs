using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Tickets> Tickets { get; set; }
        public void OnGet()
        {
             Tickets = new List<Tickets>
        {
             new Tickets{ Id= 1, Name = "Movie1",Price=5000},
                   new Tickets{ Id= 2, Name = "Movie2",Price=4000},


        };
        }
    }
}
