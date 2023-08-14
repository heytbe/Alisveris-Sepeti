using AlısverisSepetiMvc.Context;
using AlısverisSepetiMvc.Models.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlısverisSepetiMvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public CategoryController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var category = await _context.Categories.ToListAsync();
            var mapper = _mapper.Map<List<CategoryListDto>>(category);
            return View(mapper);
        }
    }
}
