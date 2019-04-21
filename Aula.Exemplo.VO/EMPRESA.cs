using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa.Online.VO
{
    public class EMPRESA
    {
        [Required(ErrorMessage = "O id da empresa é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o código de identificação da empresa")]
        [StringLength(6, MinimumLength = 6)]
        public int Id_empresa { get; set; }

        [Required(ErrorMessage = "O nome da empresa é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o nome da empresa")]
        [StringLength(150, MinimumLength = 4)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CNPJ da empresa é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o CNPJ da empresa")]
        [StringLength(18, MinimumLength = 14)]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "O campo cpf é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o cpf caso a empresa seja não tenha CNPJ")]
        [StringLength(11, MinimumLength = 11)]
        public string Cpf { get; set; }
    }
}
