namespace TestWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Entities;

    public class SiteContext : DbContext
    {
        static SiteContext()
        {
            //Database.SetInitializer<SiteContext>(new SiteContextInitializer());
        }

        public SiteContext()
            : base("name=SiteDB")
        {
        }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<MenuTranslation> MenuTranslations { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleTranslation> ArticleTranslations { get; set; }
    }
}