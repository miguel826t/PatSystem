using PatSystem.Models.Curriculo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.Curriculo
{
    public class Idioma
    {
        public int IdiomaId { get; set; }
        public Linguas Nome { get; set; }
        [Display(Name = "Instituição")]
        public string Instituicao { get; set; }
        [Display(Name = "Nivel de Fluência")]
        public LevelSpeak NivelFluencia { get; set; }
        [Display(Name = "Anos Cursados")]
        public int? AnosCursados { get; set; }

        public int CurriculoID { get; set; }
        public Curriculo Curriculo { get; set; }
    }
}
