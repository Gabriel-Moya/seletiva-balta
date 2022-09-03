using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProcessoSeletivo.Models.Base
{
    public class Content : Base
    {
        [DisplayName("Título")]
        [Required(ErrorMessage = "Título é obrigatório")]
        public string Title { get; set; }
    }
}
