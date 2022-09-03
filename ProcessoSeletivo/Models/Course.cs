using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProcessoSeletivo.Models
{
    public class Course
    {
        public Course()
        {
            Modules = new List<Modules>();
        }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Título é obrigatório")]
        public string Title { get; set; }

        [Required(ErrorMessage = "TAG é obrigatória")]
        public int Tag { get; set; }

        [DisplayName("Sumário")]
        public string Summary { get; set; }

        [DisplayName("Duração em minutos")]
        [Required(ErrorMessage = "Duração da aula é obrigatória")]
        public int DurationInMinutes { get; set; }

        [DisplayName("Módulos")]
        public List<Modules> Modules { get; set; }
    }
}
