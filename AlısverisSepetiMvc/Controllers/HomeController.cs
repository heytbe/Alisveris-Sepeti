using AlısverisSepetiMvc.Context;
using AlısverisSepetiMvc.Models.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlısverisSepetiMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public HomeController(AppDbContext context, IMapper mapper)
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

        public async Task<IActionResult> ProductDetail([FromRoute(Name = "id")] int id)
        {
            var product = await _context.Products.FindAsync(id);
            var mapper = _mapper.Map<ProductListDto>(product);
            return View(mapper);
        }

        public async Task<IActionResult> CategoryBy([FromRoute(Name ="id")] int id)
        {
            var product = await _context.Products.Where(x => x.CategoryId.Equals(id)).ToListAsync();
            var mapper = _mapper.Map<List<ProductListDto>>(product);
            return View(mapper);
        }
    }
}