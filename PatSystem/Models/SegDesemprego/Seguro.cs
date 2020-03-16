using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.SegDesemprego
{
    public class Seguro
    {
        public int SeguroId { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [Range(10, 10)]
        public int CodSeguro { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [Range(4, 6)]
        public int CodCboid { get; set; }
        public Cbo CodCbo { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [Range(5, 40)]
        public int CnpjId { get; set; }
        public Empresa Cnpj { get; set; }


    }
}
