using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDemo.Abstraction;
using WebShopDemo.Models.Brand;
using WebShopDemo.Models.Category;
using WebShopDemo.Models.Product;

namespace WebShopDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;

        public ProductController(IProductService productService, ICategoryService categoryService, IBrandService brandService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _brandService = brandService;
        }

        public ActionResult Create()
        {
            var product = new ProductCreateVM();
            product.Brands = _brandService.GetBrands()
                .Select(x => new BrandPairVM()
                {
                    Id = x.Id,
                    Name = x.BrandName
                }).ToList();
            product.Categories = _categoryService.GetCategories()
                .Select(x => new CategoryPairVM()
                {
                    Id = x.Id,
                    Name=x.CategoryName
                }).ToList();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] ProductCreateVM product)
        {
            if(ModelState.IsValid)
            {
                var createdId = _productService.Create(product.ProductName,
                    product.BrandId, product.CategoryId, product.Picture,
                    product.Quantity, product.Price, product.Discount);

                if(createdId)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }
    }
}
