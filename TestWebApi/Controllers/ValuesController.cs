using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebApi.Models;
using System.Data;

namespace BookingApp.Controllers
{
    public class ValuesController : ApiController
    {
        SiteContext db = new SiteContext();

        [HttpGet]
        public IEnumerable<ArticleTranslation> GetAllArticles()
        {
            var result = db.ArticleTranslations.ToList();

            return result;
        }

        [HttpGet]
        public ArticleTranslation GetArticle(int id)
        {
            ArticleTranslation article = db.ArticleTranslations.Find(id);

            return article;
        }

        [HttpPost]
        public void CreateArticle([FromBody]ArticleTranslation article)
        {
            db.ArticleTranslations.Add(article);
            db.SaveChanges();
        }

        [HttpPut]
        public void EditArticle(int id, [FromBody]ArticleTranslation article)
        {
            if (id == article.Id)
            {
                db.Entry(article).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        [HttpDelete]
        public void DeleteArticle(int id)
        {
            ArticleTranslation article = db.ArticleTranslations.Find(id);

            if (article != null)
            {
                db.ArticleTranslations.Remove(article);
                db.SaveChanges();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}