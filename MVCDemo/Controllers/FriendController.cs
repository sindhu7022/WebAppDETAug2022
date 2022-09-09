using Microsoft.AspNetCore.Mvc;
using MVCDemo.FriendService;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public static List<Friend> Friends { get; set; }
        public IActionResult Index()
        {
            Friends = FriendService.FriendService.GetAll();

            return View(Friends);
        }
        public IActionResult List()
        {
            List<Friend> friends = FriendService.FriendService.GetAll();
            return View(friends);
        }
        public IActionResult Details(int id)
        {
            Friend f = FriendService.FriendService.Get(id);
            return View(f);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Friend p)
        {
            FriendService.FriendService.Add(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Friend p = FriendService.FriendService.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(Friend p)
        {
            FriendService.FriendService.Delete(p.FriendID);
            return RedirectToAction("List");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit
            (Friend f)
        {
            FriendService.FriendService.Update(f);
            return RedirectToAction("List");
        }

    }
}
