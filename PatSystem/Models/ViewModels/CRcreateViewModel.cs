using PatSystem.Models.Curriculo;
using PatSystem.Models.Curriculo.Cursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.ViewModels
{
    public class CRcreateViewModel
    {
        public Cliente Cliente { get; set; }
        public CursoSuperior CursoSuperior { get; set; }
        public IEnumerable<CursoSuperior> CursosSuperior { get; set; }
        public CursoTecnico CursoTecnico { get; set; }
        public IEnumerable<CursoTecnico> CursosTecnico { get; set; }
        public Experiencia Experiencia { get; set; }
        public IEnumerable<Experiencia> Experiencias { get; set; }
        public Idioma Idioma { get; set; }
        public IEnumerable<Idioma> Idiomas { get; set; }
    }
}
