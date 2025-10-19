using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var categories = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(categories);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            _categoryService.TAdd(category);
            return Ok("Kategori Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var category = _categoryService.TGetById(id);
            _categoryService.TDelete(category);
            return Ok("Kategori Silindi");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var category = _mapper.Map<ResultCategoryDto>(_categoryService.TGetById(id));
            return Ok(category);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var category=_mapper.Map<Category>(updateCategoryDto);
            _categoryService.TUpdate(category);
            return Ok("Kategori Güncellendi");
        }
    }
}
