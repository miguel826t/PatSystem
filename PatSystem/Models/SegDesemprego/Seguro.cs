using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.SegDesemprego
{
    public class Seguro
    {
        [Required(ErrorMessage = "{0} é Obrigatório")]
        public double SeguroId { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        public string CodSeguro { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        public string Date { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        public int CodCboid { get; set; }
        public Cbo CodCbo { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        public string EmpresaId { get; set; }
        public Empresa Cnpj { get; set; }


    }
}
