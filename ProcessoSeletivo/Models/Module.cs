using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProcessoSeletivo.Models
{
    public class Module
    {
        public Module()
        {
            Lessons = new List<Lesson>();
        }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Título é obrigatório")]
        public string Title { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Ordem de exibição")]
        [Required(ErrorMessage = "A ordem da exibição é obrigatória")]
        public int DisplayOrder { get; set; }

        [DisplayName("Aulas")]
        public List<Lesson> Lessons { get; set; }
    }
}
