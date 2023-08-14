using AlısverisSepetiMvc.Context;
using AlısverisSepetiMvc.Models;
using AlısverisSepetiMvc.Models.Dto;
using AlısverisSepetiMvc.Shared;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AlısverisSepetiMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var product = await _context.Products.ToListAsync();
            var mapper = _mapper.Map<List<ProductListDto>>(product);
            return View(mapper);
        }

        public async Task<IActionResult> ProductCreate()
        {
            ViewBag.Category = await CategoryList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductCreate([FromForm] ProductCreateDto createDto)
        {
            Product product = new Product();

            product.ProductName = createDto.ProductName;
            product.ProductCheck = createDto.ProductCheck;
            product.ProductPrice = createDto.ProductPrice;
            product.CategoryId = createDto.CategoryId;
            if(createDto.ProductImage is not null)
            {
                var image = await ImageUpload.ImageUploadExtensions(createDto.ProductImage);
                product.ProductImage = image.Name;
            }

            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private async Task<SelectList> CategoryList()
        {
            return new SelectList(await _context.Categories.ToListAsync(), "Id", "CategoryName", 1);
        }
    }
}
