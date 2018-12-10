using System.ComponentModel.DataAnnotations;

namespace TestWebApi.Models
{
    public class MenuTranslation
    {
        public int Id { get; set; }

        public string Language { get; set; }

        public string Name { get; set; }

        public Menu Menu { get; set; } 
    }
}