using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRiskZones.MVC.ViewModels
{
    public class ReporteViewModel
    {
        [Key]
        public int IDReporte { get; set; }


        public string Logitude { get; set; }
        public string Latitude { get; set; }

        public DateTime DataCheckin { get; set; }

        public string Status { get; set; }


        public int IDUsuario { get; set; }
        public int IDSintoma { get; set; }
        public int IDRisco { get; set; }
        
        public virtual RiscoViewModel Risco { get; set; }
        public virtual SintomaViewModel Sitoma { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }
    }
}
