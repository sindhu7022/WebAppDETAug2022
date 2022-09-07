using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; }
        public int Discount { get; set; }
        //HTTPGET
        public void OnGet()
        {
            Message = "ASP.Net core is rocking!!";
            Discount = 15;
        }
    }
}
