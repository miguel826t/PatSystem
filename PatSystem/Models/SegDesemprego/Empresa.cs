using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.SegDesemprego
{
    public class Empresa
    {
        public int EmpresaId { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} deve ter de {2} a {1} caracteres")]
        [Required(ErrorMessage = "{0} é Obrigatório")]
        public string Nome { get; set; }

        public string Segmento { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        public string CnpjId { get; set; }
    }
}
