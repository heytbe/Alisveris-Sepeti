using AlısverisSepetiMvc.Context;
using AlısverisSepetiMvc.Models;
using AlısverisSepetiMvc.Models.Dto;
using AlısverisSepetiMvc.Models.ViewModel;
using AlısverisSepetiMvc.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlısverisSepetiMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var category = await _context.Categories.ToListAsync();
            CategoryVm categoryVm = new CategoryVm();
            categoryVm.Category = category;

            return View(categoryVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([FromForm]CategoryCreateDto createDto)
        {
            Category category = new Category();

            category.CategoryName = createDto.CategoryName;
            category.CategoryCheck = createDto.CategoryCheck;
            category.CategoryColor = createDto.CategoryColor;
            if(createDto.CategoryImage is not null)
            {
                var image = await ImageUpload.ImageUploadExtensions(createDto.CategoryImage);
                category.CategoryImage = image.Name;
            }

            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
