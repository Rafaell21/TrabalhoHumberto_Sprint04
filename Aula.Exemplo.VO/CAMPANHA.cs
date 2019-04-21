using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa.Online.VO
{
    public class CAMPANHA
    {
        [Required(ErrorMessage = "O id da campanha é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Digite o código de identificação da campanha")]
        [StringLength(6, MinimumLength = 6)]
        public int Id_campanha { get; set; }

        [Required(ErrorMessage = "O id do responsavel da campanha é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o código de identificação do funcionário")]
        [StringLength(6, MinimumLength = 6)]
        public int Id_responsavel { get; set; }

        [Required(ErrorMessage = "O nome da campanha é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Digite o nome do funcionário")]
        [StringLength(150, MinimumLength = 4)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O preenchimento da data de inicio é obrigatorio. 'Exemplo:11/11/2011'", AllowEmptyStrings = false)]
        [Display(Name = "Digite a data de inicio da campanha")]
        [StringLength(10, MinimumLength = 8)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime Dt_inicio { get; set; }

        [Required(ErrorMessage = "O preenchimento da data final é obrigatorio. 'Exemplo:11/11/2011'", AllowEmptyStrings = false)]
        [Display(Name = "Digite a data do final da campanha")]
        [StringLength(10, MinimumLength = 8)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime Dt_fim { get; set; }
    }
}
