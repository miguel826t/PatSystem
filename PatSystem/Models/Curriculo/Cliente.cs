using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.Curriculo
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} deve ter de {2} a {1} caracteres")]
        [Required(ErrorMessage = "{0} é Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Tl. Fixo")]
        [Required(ErrorMessage = "{0} é Obrigatório")]
        [DataType(DataType.PhoneNumber)]
        public int TlFixo { get; set; }


        [Required(ErrorMessage = "{0} é Obrigatório")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Celular")]
        public int TlMovel { get; set; }

        [EmailAddress(ErrorMessage = "Insira um E-mail valido")]
        [Required(ErrorMessage = "{0} é Obrigatório")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "{0} deve ter de {2} a {1} caracteres")]
        [Display(Name = "Área de Atuação")]
        public string AreaAtuacao { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [Display(Name = "Ensino Médio")]
        public string EnsinoMedio { get; set; }

        public int Idade { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        public string UF { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} deve ter de {2} a {1} caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} deve ter de {2} a {1} caracteres")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        public int Numero { get; set; }

        

        public void CalcIdade()
        {
            Idade = DateTime.Now.Year - Nascimento.Year;
        }
    }
}
