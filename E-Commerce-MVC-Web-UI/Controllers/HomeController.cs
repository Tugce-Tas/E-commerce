using E_Commerce_MVC_Web_UI.Entity;
using E_Commerce_MVC_Web_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce_MVC_Web_UI.Controllers
{
    public class HomeController : Controller
    { 
        DataContext _context = new DataContext();
        
        public ActionResult Index()
        {
            var products = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id= i.Id,
                    Name = i.Name.Length > 65 ? i.Name.Substring(0, 62) + "..." : i.Name,
                    Description = i.Description.Length > 100 ? i.Description.Substring(0,97) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock, 
                    Image = i.Image ?? "null.png",
                    CategoryId = i.CategoryId, 
                }).ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }
        public ActionResult List(int? id )
        {
            var products = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 45 ? i.Name.Substring(0, 42) + "..." : i.Name,
                    Description = i.Description.Length > 75 ? i.Description.Substring(0, 72) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "null.png",
                    CategoryId = i.CategoryId,
                }).AsQueryable(); ;

            if (id != null)
            {
                products = products.Where(i => i.CategoryId == id);
            }

            return View(products.ToList());
        }


        public PartialViewResult GetCategories() 
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}