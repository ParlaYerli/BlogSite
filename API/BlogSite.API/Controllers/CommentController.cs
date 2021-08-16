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
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _service;
        public CommentController(ICommentService service)
        {
            _service = service;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_service.GetList());
        }

        [HttpGet("getbyid/{commentId}")]
        public IActionResult GetCommentById(int commentId)
        {
            var comment = _service.GetById(commentId);
            if (comment == null)
            {
                return NotFound(new { message = "Comment bulunamadı" });
            }
            return Ok(comment);
        }

        [HttpPost("add")]
        public IActionResult Add(Comment comment)
        {
            if (ModelState.IsValid)
            {
                _service.Add(comment);
                return Ok(comment);
            }
            return BadRequest(new { message = "Eksik bilgi girdiniz.Gerekli alanları doldurunuz." });
        }

        [HttpDelete("{commentId}")]
        public ActionResult Delete(int commentId)
        {
            var comment = _service.GetById(commentId);
            if (comment == null)
            {
                return NotFound(new { message = "Comment bulunamadı" });
            }
            _service.Delete(comment);
            return Ok(new { message = "Comment başarıyla silindi" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Comment comment)
        {
            if (id != comment.Id)
            {
                return BadRequest(new { message = "Comment bilgisi hatalı" });
            }
            _service.Update(comment);
            return Ok(new { message = "Comment başarıyla güncellendi" });
        }
    }
}
