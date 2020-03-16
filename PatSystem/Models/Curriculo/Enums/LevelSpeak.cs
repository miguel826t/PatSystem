using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.Curriculo.Enums
{
    public enum LevelSpeak : int
    {
        [Display(Name = "Não Possui")]
        Nao = 0,
        Basico = 1,
        [Display(Name = "Médio")]
        Medio = 2,
        Fluente = 3
    }
}
