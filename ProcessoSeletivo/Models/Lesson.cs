using ProcessoSeletivo.Models.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProcessoSeletivo.Models
{
    public class Lesson : Content
    {
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("URL")]
        [Required(ErrorMessage = "URL é obrigatória")]
        public string Url { get; set; }

        public Guid ModuleId { get; set; }

        [DisplayName("Módulo")]
        public virtual Module Module { get; set; }
    }
}
