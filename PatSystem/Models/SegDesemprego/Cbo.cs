using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.SegDesemprego
{
    public class Cbo
    {
        [Required(ErrorMessage = "{0} é Obrigatório")]
        [Range(4, 10)]
        public int CodCboId { get; set; }

        [Required(ErrorMessage = "{0} é Obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} deve ter de {2} a {1} caracteres")]
        public string Desc { get; set; }
    }
}
