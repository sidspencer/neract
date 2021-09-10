using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using neract_back.Pocos;

namespace neract_back.Services
{
  public class ArticleService 
  {
    /// Singleton. Private Constructor.
    private static ArticleService inst = null;
    private ArticleService() { }


    /// Get the Singleton instance.
    public static ArticleService Inst 
    {
      get
      {
        if (inst == null) { inst = new ArticleService(); };
        return inst;
      }
    }


    /// Get a single article by id.
    public Article GetArticle(int id = -99) 
    {
      return new Article 
      { 
        Id = id 
      };
    }


    /// Get many articles, optionally filered by a search.
    public IEnumerable<Article> SearchArticles(string search = null)
    {
      List<Article> ret = new List<Article> 
      {
        new Article { Id = 5 },
        new Article { Id = 87 }
      };

      return ret;
    }


    /// Do DB Stuff. That's where the ID will come from.
    public Article CreateArticle(Article ar) 
    {
      return new Article 
      {
        Id = 777,
        PublishDate = DateTime.UtcNow,
        Author = ar.Author,
        Title = ar.Title,
        Body = ar.Body,
        Keywords = ar.Keywords     
      };
    }


    /// Do DB Stuff on PUT. Only authorized users can do this. When it succeds, return the article
    public Article UpdateArticle(Article ar) 
    {
      return new Article
      {
        Id = ar.Id,
        PublishDate = DateTime.UtcNow,
        Author = ar.Author,
        Title = ar.Title,
        Body = ar.Body,
        Keywords = ar.Keywords     
      };
    }


    /// Do DB Stuff on DELETE. Only authorized users can do this.
    public WsStatus DeleteArticle(int id)
    {
      WsStatus stat = new WsStatus 
      { 
        Success = true, 
        WarningMessage = string.Empty, 
        DebugInfo = string.Format("Deleted Article {0}.", id) 
      };

      return stat;
    }
  }
}
