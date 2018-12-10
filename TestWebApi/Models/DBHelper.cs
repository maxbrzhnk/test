using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWebApi.Models
{
    public class DBHelper
    {
        public class CompactMenu
        {
            public string UrlName { get; }
            public string Name { get; }

            public CompactMenu(string name)
            {
                this.Name = name;
                this.UrlName = DBHelper.GetUrlMenuByName(name);
            }
        }

        private static string GetUrlMenuByName(string name)
        {
            using (SiteContext db = new SiteContext())
            {
                try
                {
                    /*Small changes*/

                    /*Small changes*/
                    /*Small changes*/
                    /*Small changes*/  /*Small changes*/

                    /*Small changes*/
                    /*Small changes*/
                    /*Small changes*/  /*Small changes*/

                    /*Small changes*/
                    /*Small changes*/
                    /*Small changes*/  /*Small changes*/

                    /*Small changes*/
                    /*Small changes*/
                    /*Small changes*/
                    return db.Menus
                    .FirstOrDefault(menu => menu.Translations
                        .Any(translation => translation.Name == name))
                    .UrlName;
                }
                catch (NullReferenceException)
                {
                    return null;
                }                
            }
        }

        public string GetMenu(string language, string urlName)
        {
            using (SiteContext db = new SiteContext())
            {
                try
                {
                    return db.MenuTranslations
                        .Where(translation => translation.Menu.UrlName == urlName)
                        .FirstOrDefault(translation => translation.Language == language).Name;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public List<string> GetMenus(string language)
        {
            using (SiteContext db = new SiteContext())
            {
                try
                {
                    return db.MenuTranslations
                        .Where(translation => translation.Language == language)
                        .Select(translation => translation.Name)
                        .ToList();
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        public List<ArticleTranslation> GetArticles(string menuName, string language)
        {
            using (SiteContext db = new SiteContext())
            {
                try
                {
                    return db.ArticleTranslations
                    .Where(translation => translation.Language == language)
                    .Where(translation => translation.Article.Menus
                        .Any(menu => menu.Translations
                            .Any(menuTranslation => menuTranslation.Name == menuName)))
                    .Include(translation => translation.Article)
                    .ToList();
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        public List<ArticleTranslation> GetArticles(string menuName, int count, string language)
        {
            using (SiteContext db = new SiteContext())
            {
                try
                {
                    return db.ArticleTranslations
                    .Where(translation => translation.Language == language)
                    .Where(translation => translation.Article.Menus
                        .Any(menu => menu.Translations
                            .Any(menuTranslation => menuTranslation.Name == menuName)))
                    .Take(count)
                    .Include(translation => translation.Article)
                    .ToList();
                }
                catch
                {
                    return null;
                }
                
            }
        }

        public ArticleTranslation GetArticle(string articleUrlName, string language)
        {
            using (SiteContext db = new SiteContext())
            {
                try
                {
                    return db.ArticleTranslations
                    .Where(translation => translation.Language == language)
                    .FirstOrDefault(translation => translation.Article.UrlName == articleUrlName);
                }
                catch (NullReferenceException)
                {
                    return null;
                }                
            }
        }
    }
}