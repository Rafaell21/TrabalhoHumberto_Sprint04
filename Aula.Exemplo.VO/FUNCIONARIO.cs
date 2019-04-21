using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pesquisa.Online.VO
{
    public class FUNCIONARIO
    {
        [Required(ErrorMessage = "O id do funcionario é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o código de identificação do funcionário")]
        [StringLength(6, MinimumLength = 6)]
        public int Id_funcionario { get; set; }

        [Required(ErrorMessage = "O id da empresa é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o código de identificação da empresa")]
        [StringLength(6, MinimumLength = 6)]
        public int Id_empresa { get; set; }

        [Required(ErrorMessage = "O nome do funcionario é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o nome do funcionario")]
        [StringLength(150, MinimumLength = 4)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email do funcionario é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o email válido")]
        [StringLength(150, MinimumLength = 6)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O senha é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Digite a sua senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O CPF do funcionario é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Digite o CPF do funcionário")]
        [StringLength(11, MinimumLength = 11)]
        public char CPF { get; set; }

    }
}
