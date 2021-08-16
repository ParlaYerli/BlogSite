using BlogSite.Business.Abstract;
using BlogSite.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_service.GetList());
        }

        [HttpGet("getbyid/{categoryId}")]
        public IActionResult GetCategoryById(int categoryId)
        {
            var category = _service.GetById(categoryId);
            if (category == null)
            {
                return NotFound(new { message = "Category bulunamadı" });
            }
            return Ok(category);
        }

        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _service.Add(category);
                return Ok(category);
            }
            return BadRequest(new { message = "Eksik bilgi girdiniz.Gerekli alanları doldurunuz." });
        }

        [HttpDelete("{categoryId}")]
        public ActionResult Delete(int categoryId)
        {
            var category = _service.GetById(categoryId);
            if (category == null)
            {
                return NotFound(new { message = "Category bulunamadı" });
            }
            _service.Delete(category);
            return Ok(new { message = "Category başarıyla silindi" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest(new { message = "Category bilgisi hatalı" });
            }
            _service.Update(category);
            return Ok(new { message = "Category başarıyla güncellendi" });
        }

    }
}
