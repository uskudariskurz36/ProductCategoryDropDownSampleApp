using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductCategoryDropDownSampleApp.Entities;
using ProductCategoryDropDownSampleApp.Models;

namespace ProductCategoryDropDownSampleApp.Controllers
{
    public class ProductController : Controller
    {
        private DatabaseContext db;
        private IMapper mapper;

        public ProductController(DatabaseContext databaseContext, IMapper mapperObject)
        {
            db = databaseContext;
            mapper = mapperObject;
        }


        public IActionResult Create()
        {
            ProductCreateViewModel model = new ProductCreateViewModel();

            List<Category> categories = db.Categories.ToList();

            model.Categories = new SelectList(categories, "Id", "Name");

            return View(model);
        }


        [HttpPost]
        public IActionResult Create(ProductCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Product product = new Product()
                //{
                //    Name = model.Name,
                //    Price = model.Price,
                //    CategoryId = model.CategoryId,
                //};

                Product product = mapper.Map<Product>(model);

                db.Products.Add(product);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            List<Category> categories = db.Categories.ToList();

            model.Categories = new SelectList(categories, "Id", "Name");

            return View(model);
        }
    }
}
