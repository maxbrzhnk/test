using System.ComponentModel.DataAnnotations;

namespace TestWebApi.Models
{
    public class ArticleTranslation
    {
        public int Id { get; set; }

        public string Language { get; set; }

        public string Header { get; set; }

        public string TextTeaser { get; set; }

        public string HtmlContent { get; set; }

        public string ImageUrlTeaser { get; set; }

        public string ImageUrl { get; set; }

     
        public Article Article { get; set; }
    }
}