﻿using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Service;

namespace MVCDemo.Controllers
{
   
        public class PizzaController : Controller
        {
            public IActionResult Index()
            {
                List<Pizza> pizzas = PizzaService.GetAll();
                return View(pizzas);
            }

            public IActionResult Details(int id)
            {
                Pizza p = PizzaService.Get(id);
                return View(p);
            }
        public IActionResult List()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        //public IActionResult Create(int id,string name , int size, decimal price, bool Isglutenfree)

        //{
        //    Pizza p = new Pizza { Id = id, Name = name, Size = (PizzaSize)size, Price=price,IsGlutenFree=Isglutenfree};
        //    PizzaService.Add(p);
        //    return RedirectToAction("List");
        //}
        public IActionResult Create(Pizza p)
        {
            PizzaService.Add(p);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            Pizza p = PizzaService.Get(id);
            if(p!= null)
                return View(p);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            PizzaService.Delete(p.Id);
            return RedirectToAction("List");
        }

    }
}
