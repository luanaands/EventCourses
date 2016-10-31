using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Entidades
{
    public class InscricaoCurso
    {

        public int Id { get; set; }

        public virtual Curso Curso { get; set; }

        public int CursoId { get; set; }

        public Participante Participante { get; set; }

        public int ParticipanteId { get; set; }


    }
}