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
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _service;

        public ArticleController(IArticleService service)
        {
            _service = service;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_service.GetList());
        }

        [HttpGet("getbyid/{articleId}")]
        public IActionResult GetArticleById(int articleId)
        {
            var article = _service.GetById(articleId);
            if (article == null)
            {
                return NotFound(new { message = "Article bulunamadı" });
            }
            return Ok(article);
        }

        [HttpPost("add")]
        public IActionResult Add(Article article)
        {
            if (ModelState.IsValid)
            {
                _service.Add(article);
                return Ok(article);
            }
            return BadRequest(new { message = "Eksik bilgi girdiniz.Gerekli alanları doldurunuz." });
        }

        [HttpDelete("{articleId}")]
        public ActionResult Delete(int articleId)
        {
            var article = _service.GetById(articleId);
            if (article == null)
            {
                return NotFound(new { message = "Article bulunamadı" });
            }
            _service.Delete(article);
            return Ok(new { message = "Article başarıyla silindi" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Article article)
        {
            if (id != article.Id)
            {
                return BadRequest(new { message = "Article bilgisi hatalı" });
            }
            _service.Update(article);
            return Ok(new { message = "Article başarıyla güncellendi" });
        }
    }
}
