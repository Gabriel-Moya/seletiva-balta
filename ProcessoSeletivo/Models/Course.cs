using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ProcessoSeletivo.Models.Base;

namespace ProcessoSeletivo.Models
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }

        [Required(ErrorMessage = "TAG é obrigatória")]
        public int Tag { get; set; }

        [DisplayName("Sumário")]
        public string Summary { get; set; }

        [DisplayName("Duração em minutos")]
        [Required(ErrorMessage = "Duração da aula é obrigatória")]
        public int DurationInMinutes { get; set; }

        [DisplayName("Módulos")]
        public IList<Module> Modules { get; set; }
    }
}
