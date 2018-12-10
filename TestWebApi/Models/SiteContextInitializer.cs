using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestWebApi.Models
{
    public class SiteContextInitializer: DropCreateDatabaseAlways<SiteContext>
    {
        protected override void Seed(SiteContext db)
        {            
            #region English article translations
            ArticleTranslation at1 = new ArticleTranslation
            {
                Language = "en",
                Header = "Web development",
                TextTeaser = "Backend and frontend development.",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at2 = new ArticleTranslation
            {
                Language = "en",
                Header = "Mobile development",
                TextTeaser = "Native IOS and Android development.",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at3 = new ArticleTranslation
            {
                Language = "en",
                Header = "Project Management",
                TextTeaser = "Joke about Carsten.",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at4 = new ArticleTranslation
            {
                Language = "en",
                Header = "Design",
                TextTeaser = "Web, mobile, UI/US design",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };
            /********/

            /*Cases*/
            ArticleTranslation at5 = new ArticleTranslation
            {
                Language = "en",
                Header = "Unify App",
                TextTeaser = "Awesome contract manager!",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/mr-square_icon.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at6 = new ArticleTranslation
            {
                Language = "en",
                Header = "Second App",
                TextTeaser = "This project we made from the very beginning.",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/mr-square_icon.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at7 = new ArticleTranslation
            {
                Language = "en",
                Header = "Third App",
                TextTeaser = "We have partnership in this project.",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/mr-square_icon.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };
            /********/

            /*Prices*/ //HERE SHOULD ADDED HTML FOR CORRECT WORK!!!
            ArticleTranslation at8 = new ArticleTranslation
            {
                Language = "en",
                Header = "Dedicated team",
                TextTeaser = "<h5>Average</h5>" +
                             "<h4>18.200 SEK</h4>" +
                             "<h5>per/month</h5>",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at9 = new ArticleTranslation
            {
                Language = "en",
                Header = "Fixed project",
                TextTeaser = "<h5>Average</h5>" +
                             "<h4>550 SEK</h4>" +
                             "<h5>per/hour</h5>",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at10 = new ArticleTranslation
            {
                Language = "en",
                Header = "Freelancers",
                TextTeaser = "<h5>Average</h5>" +
                             "<h4>378 SEK</h4>" +
                             "<h5>per/hour</h5>",
                HtmlContent = "Some big content",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };
            #endregion

            #region Ukraine article translations
            ArticleTranslation at1UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Веб розробка",
                TextTeaser = "Backend та frontend розробка.",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at2UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Мобільна розробка",
                TextTeaser = "IOS та Android розробка.",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at3UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Управління проектами",
                TextTeaser = "Цим займається Карстен.",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at4UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Дизайн",
                TextTeaser = "Веб, мобільний, UI/US дизайн",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };
            /********/

            /*Cases*/
            ArticleTranslation at5UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Unify App",
                TextTeaser = "Крута штука!",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/mr-square_icon.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at6UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Second App",
                TextTeaser = "Цей проект ми починали з піцки.",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/mr-square_icon.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at7UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Third App",
                TextTeaser = "Жили у бабусі три веселих гуся.",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/mr-square_icon.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };
            /********/

            /*Prices*/ //HERE SHOULD ADDED HTML FOR CORRECT WORK!!!
            ArticleTranslation at8UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Команда",
                TextTeaser = "<h5>Середня ціна</h5>" +
                             "<h4>18.200 SEK</h4>" +
                             "<h5>в місяць</h5>",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at9UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Проект",
                TextTeaser = "<h5>Середня ціна</h5>" +
                             "<h4>550 SEK</h4>" +
                             "<h5>за годину</h5>",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            ArticleTranslation at10UK = new ArticleTranslation
            {
                Language = "uk",
                Header = "Фрілансери",
                TextTeaser = "<h5>Середня ціна</h5>" +
                             "<h4>378 SEK</h4>" +
                             "<h5>за годину</h5>",
                HtmlContent = "Великий контент",
                ImageUrlTeaser = @"/Content/Images/Car.png",
                ImageUrl = @"/Content/Images/Robots.png"
            };

            #endregion

            db.ArticleTranslations.AddRange(new List<ArticleTranslation> { at1, at2, at3, at4, at5, at6, at7, at8, at9, at10, at1UK, at2UK, at3UK, at4UK, at5UK, at6UK, at7UK, at8UK, at9UK, at10UK });
            db.SaveChanges();

            #region Articles
            Article a1 = new Article
            {
                UrlName = "Web-development"
            };
            a1.Translations = new List<ArticleTranslation>();
            a1.Translations.Add(at1);
            a1.Translations.Add(at1UK);

            Article a2 = new Article
            {
                UrlName = "Mobile-development"
            };
            a2.Translations = new List<ArticleTranslation>();
            a2.Translations.Add(at2);
            a2.Translations.Add(at2UK);

            Article a3 = new Article
            {
                UrlName = "Project-Management"
            };
            a3.Translations = new List<ArticleTranslation>();
            a3.Translations.Add(at3);
            a3.Translations.Add(at3UK);

            Article a4 = new Article
            {
                UrlName = "Design"
            };
            a4.Translations = new List<ArticleTranslation>();
            a4.Translations.Add(at4);
            a4.Translations.Add(at4UK);

            Article a5 = new Article
            {
                UrlName = "Unify-App"
            };
            a5.Translations = new List<ArticleTranslation>();
            a5.Translations.Add(at5);
            a5.Translations.Add(at5UK);

            Article a6 = new Article
            {
                UrlName = "Second-App"
            };
            a6.Translations = new List<ArticleTranslation>();
            a6.Translations.Add(at6);
            a6.Translations.Add(at6UK);

            Article a7 = new Article
            {
                UrlName = "Third-App"
            };
            a7.Translations = new List<ArticleTranslation>();
            a7.Translations.Add(at7);
            a7.Translations.Add(at7UK);

            Article a8 = new Article
            {
                UrlName = "Dedicated-team"
            };
            a8.Translations = new List<ArticleTranslation>();
            a8.Translations.Add(at8);
            a8.Translations.Add(at8UK);

            Article a9 = new Article
            {
                UrlName = "Fixed-project"
            };
            a9.Translations = new List<ArticleTranslation>();
            a9.Translations.Add(at9);
            a9.Translations.Add(at9UK);

            Article a10 = new Article
            {
                UrlName = "Freelancers"
            };
            a10.Translations = new List<ArticleTranslation>();
            a10.Translations.Add(at10);
            a10.Translations.Add(at10UK);

            db.Articles.AddRange(new List<Article> { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 });
            db.SaveChanges();
            #endregion

            #region English menu translations
            MenuTranslation mt1 = new MenuTranslation { Language = "en", Name = "Service" };

            MenuTranslation mt2 = new MenuTranslation { Language = "en", Name = "Cases" };

            MenuTranslation mt3 = new MenuTranslation { Language = "en", Name = "Price" };
            #endregion

            #region Ukraine menu translations
            MenuTranslation mt1UK = new MenuTranslation { Language = "uk", Name = "Послуги" };

            MenuTranslation mt2UK = new MenuTranslation { Language = "uk", Name = "Проекти" };

            MenuTranslation mt3UK = new MenuTranslation { Language = "uk", Name = "Ціни" };
            #endregion

            db.MenuTranslations.AddRange(new List<MenuTranslation> { mt1, mt2, mt3, mt1UK, mt2UK, mt3UK });
            db.SaveChanges();

            #region Menus
            Menu m1 = new Menu
            {
                UrlName = "Service"
            };//I had m1.Articles = new List()
            m1.Translations = new List<MenuTranslation>();
            m1.Translations.Add(mt1);
            m1.Translations.Add(mt1UK);
            m1.Articles = new List<Article>();
            m1.Articles.Add(a1);
            m1.Articles.Add(a2);
            m1.Articles.Add(a3);
            m1.Articles.Add(a4);

            Menu m2 = new Menu
            {
                UrlName = "Cases"
            };
            m2.Translations = new List<MenuTranslation>();
            m2.Translations.Add(mt2);
            m2.Translations.Add(mt2UK);
            m2.Articles = new List<Article>();
            m2.Articles.Add(a5);
            m2.Articles.Add(a6);
            m2.Articles.Add(a7);

            Menu m3 = new Menu
            {
                UrlName = "Price"
            };
            m3.Translations = new List<MenuTranslation>();
            m3.Translations.Add(mt3);
            m3.Translations.Add(mt3UK);
            m3.Articles = new List<Article>();
            m3.Articles.Add(a8);
            m3.Articles.Add(a9);
            m3.Articles.Add(a10);
            #endregion

            db.Menus.AddRange(new List<Menu> { m1, m2, m3 });

            db.SaveChanges();
        }
    }
}