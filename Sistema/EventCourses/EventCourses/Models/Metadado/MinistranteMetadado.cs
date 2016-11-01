using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Metadado
{
    [MetadataType(typeof(MinistranteMetadado))]
    public partial class Ministrante
    {
    }

    public class MinistranteMetadado
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Perfil")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "CPF")]
        public String Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Especialidade")]
        public String Especialidade { get; set; }

    }
}