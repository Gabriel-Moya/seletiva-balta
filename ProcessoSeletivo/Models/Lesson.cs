using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProcessoSeletivo.Models
{
    public class Lesson
    {
        [DisplayName("Título")]
        [Required(ErrorMessage = "Título é obrigatório")]
        public string Title { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("URL")]
        [Required(ErrorMessage = "URL é obrigatória")]
        public string Url { get; set; }
    }
}
