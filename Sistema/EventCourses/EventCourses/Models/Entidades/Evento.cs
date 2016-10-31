using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Entidades
{
    public class Evento
    {
        public int Id { get; set; }

        public String Razao { get; set; }

        public int QuantidadeDias { get; set; }

        public virtual IList<Curso> Cursos { get; set; }

        public virtual IList<Palestra> Palestras { get; set; }

        public virtual IList<Oficina> Oficinas { get; set; }

        public int QuantidadeMinistrantes { get; set; }

        public int QuantidadeParticipantes { get; set; }






    }
}