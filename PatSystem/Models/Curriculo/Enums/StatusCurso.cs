using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.Curriculo.Enums
{
    public enum StatusCurso : int
    {
        [Display(Name = "Não Cursa")]
        NaoCursa = 0,
        [Display(Name = "Está Cursando")]
        Cursando = 1,
        [Display(Name = "Concluído")]
        Concluido = 2
    }
}
