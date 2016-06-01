using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRiskZones.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sexo")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Raça")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Raca { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Senha { get; set; }


        public string IDUsuario { get; set; }
        public string IDFacebook { get; set; }
        public DateTime Nascimento { get; set; }
        public bool ISMembro { get; set; }

        public virtual IEquatable<ReporteViewModel> Reportes { get; set; }
    }
}
