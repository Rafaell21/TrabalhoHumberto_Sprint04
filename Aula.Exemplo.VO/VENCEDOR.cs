using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pesquisa.Online.VO
{
    public class VENCEDOR
    {
        public int Id_vencedor { get; set; }
        [Required(ErrorMessage = "É obrigatório o preenchimento desse campo, diga o porque está foi a resposta vencedora.", AllowEmptyStrings = false)]
        [Display(Name = "Descreva porque está é a resposta vencedora.")]
        [StringLength(500, MinimumLength = 5)]
        public int Observação { get; set; }

        public int Id_resposta { get; set; }

        public string Id_funcionario { get; set; }

        public string Id_campanha { get; set; }
    }
}
