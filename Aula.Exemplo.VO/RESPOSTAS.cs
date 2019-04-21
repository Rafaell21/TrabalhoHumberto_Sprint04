using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa.Online.VO
{
    public class RESPOSTAS
    {

        public int Id_resposta { get; set; }

        public int Id_funcionario { get; set; }

        public int Id_campanha { get; set; }
        [Required(ErrorMessage = "É obrigatório o preenchimento do campo resposta", AllowEmptyStrings = false)]
        [Display(Name = "Digite a resposta)")]
        [StringLength(150, MinimumLength = 5)]
        public string Resposta1 { get; set; }
        
        [Required(ErrorMessage = "É obrigatório o preenchimento do campo resposta", AllowEmptyStrings = false)]
        [Display(Name = "Digite a resposta")]
        [StringLength(3000, MinimumLength = 5)]
        public string Resposta2 { get; set; }

        [Required(ErrorMessage = "É obrigatório o preenchimento do campo resposta", AllowEmptyStrings = false)]
        [Display(Name = "Digite a resposta")]
        [StringLength(150, MinimumLength = 5)]
        public string Resposta3 { get; set; }

        [Required(ErrorMessage = "É obrigatório o preenchimento do campo resposta", AllowEmptyStrings = false)]
        [Display(Name = "Digite a resposta")]
        [StringLength(10, MinimumLength = 8)]
        public string Resposta4 { get; set; }

        [Required(ErrorMessage = "É obrigatório o preenchimento do campo resposta", AllowEmptyStrings = false)]
        [Display(Name = "Digite a resposta")]
        [StringLength(10, MinimumLength = 8)]
        public string Resposta5 { get; set; }

        [Required(ErrorMessage = "É obrigatório o preenchimento do campo resposta", AllowEmptyStrings = false)]
        [Display(Name = "Digite a resposta")]
        [StringLength(1000, MinimumLength = 8)]
        public string Resposta6 { get; set; }

        [Required(ErrorMessage = "É obrigatório o preenchimento do campo resposta", AllowEmptyStrings = false)]
        [Display(Name = "Digite a resposta")]
        [StringLength(150, MinimumLength = 5)]
        public string Resposta7 { get; set; }
    }
}
