using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleManagement.Model;
using ArticleManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ArticleManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {

        private readonly IRepository<Article> articleRepository;
        public ArticleController(IRepository<Article> articleRepository)
        {
            this.articleRepository = articleRepository;
        }


        [Route("getAll")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(articleRepository.All());
        }


        [Route("getById/{id}")]
        public ActionResult<string> Get(long id)
        {
            var article = articleRepository.GetById(id);
            if (article == null) return NotFound();

            return Ok(article);
        }



        [Route("update/{id}")]
        public IActionResult Update(long id, [FromBody] Article article)
        {
            Article currentArticle = articleRepository.GetById(id);
            if (currentArticle == null) return NotFound();
            article.ArticleId = currentArticle.ArticleId;
            if (articleRepository.Update(article))
                return Ok(article);
            return BadRequest();

        }


        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest();
            var article = articleRepository.GetById(id);
            if (article == null) return NotFound();

            bool response =articleRepository.Delete(article);
            if (response) return Ok("ArticleId :"+" "+article.ArticleId.ToString() +" "+ "has been deleted");

            return BadRequest();




        }
    }
}
