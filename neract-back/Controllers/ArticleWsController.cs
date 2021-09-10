using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using neract_back.Pocos;
using neract_back.Services;



namespace neract_back.Controllers
{
    [ApiController]
    [Route("api/v1/articles")]
    public class ArticleWsController : ControllerBase
    {
        private readonly ArticleService srv = ArticleService.Inst; 

        [HttpGet]
        [Route("{*search:length(2,128)}")]
        public IEnumerable<Article> SearchArticles(string search)
        {
            return srv.SearchArticles(search);
        }

        [HttpGet]
        [Route("{id:int}")]
        public Article GetOne(int id) {
            return srv.GetArticle(id);
        }

        [HttpPost]
        [Route("{id:int}")]
        public Article PostNew([FromBody] Article ar)
        {
            return srv.CreateArticle(ar);
        }

        [HttpPut]
        [Route("{id;int}")]
        public Article PutUpdated([FromBody] Article ar)
        {
            return srv.UpdateArticle(ar);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public WsStatus DeleteOne(int id)
        {
            return srv.DeleteArticle(id);
        }
    }
}
