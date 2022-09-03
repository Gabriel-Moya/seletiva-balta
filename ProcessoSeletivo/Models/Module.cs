using ProcessoSeletivo.Models.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProcessoSeletivo.Models
{
    public class Module : Content
    {
        public Module()
        {
            Lessons = new List<Lesson>();
        }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Ordem de exibição")]
        [Required(ErrorMessage = "A ordem da exibição é obrigatória")]
        public int DisplayOrder { get; set; }

        [DisplayName("Aulas")]
        public IList<Lesson> Lessons { get; set; }

        [DisplayName("Cursos")]
        public Course Course { get; set; }
    }
}
