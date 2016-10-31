using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Entidades
{
    public class Curso
    {

        public int Id { get; set; }

        public String Tema { get; set; }

        public int NumeroSala { get; set; }

        public String DescricaoSala { get; set; }

        public DateTime? Inicio { get; set; }

        public DateTime? Fim { get; set; }

        public Ministrante MinistrantePalestra { get; set; }

        public virtual int MinistranteId { get; set; }

        public int SuporteParticipante { get; set; }

    }
}