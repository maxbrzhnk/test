using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApi.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string UrlName { get; set; }

        public IList<ArticleTranslation> Translations { get; set; }

        public IList<Menu> Menus { get; set; }
    }
}