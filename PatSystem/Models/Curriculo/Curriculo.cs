using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.Curriculo
{
    public class Curriculo
    {
        public int CurriculoID { get; set; }

        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime DataCriacao { get; set; }
        public string CursoSuperiorSN { get; set; }
        public string CursoTecnicoSN { get; set; }
        public string IdiomaSN { get; set; }
        public string ExperienciaSN { get; set; }

    }
}
