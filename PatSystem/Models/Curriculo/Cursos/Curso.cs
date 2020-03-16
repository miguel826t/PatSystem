using PatSystem.Models.Curriculo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.Curriculo.Cursos
{
    public class Curso
    {
        public int CurriculoID { get; set; }
        public Curriculo Curriculo { get; set; }
        public string Nome { get; set; }
        public string Modalidade { get; set; }
        [Display(Name = "Instituição")]
        public string Instituicao { get; set; }
        public string Tipo { get; set; }
        public StatusCurso Status { get; set; }
    }
}
