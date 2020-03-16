using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatSystem.Models.Curriculo
{
    public class Experiencia
    {
        public int ExperienciaId { get; set; }
        [Display(Name = "Nome da Empresa")]
        public string NomeEmpresa { get; set; }
        [Display(Name = "Último Cargo")]
        public string UltimoCargo { get; set; }
        [Display(Name = "Anos de Experiência")]
        public double? Anos { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public int CurriculoID { get; set; }
        public Curriculo Curriculo { get; set; }
    }
}
