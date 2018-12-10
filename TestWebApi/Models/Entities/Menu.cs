using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApi.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public string UrlName { get; set; }

        public IList<MenuTranslation> Translations { get; set; }

        public IList<Article> Articles { get; set; }
    }
}