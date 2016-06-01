using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRiskZones.MVC.ViewModels
{
    public class RiscoViewModel
    {

        [Key]
        public int IDRisco { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string RiscoNome { get; set; }

        public virtual IEquatable<ReporteViewModel> Reportes { get; set; }
    }
}
