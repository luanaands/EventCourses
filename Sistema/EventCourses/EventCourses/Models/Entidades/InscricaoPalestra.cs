using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Entidades
{
    public class InscricaoPalestra
    {

        public int Id { get; set; }

        public virtual Palestra Palestra { get; set; }

        public int PalestraId { get; set; }

        public Participante Participante { get; set; }

        public int ParticipanteId { get; set; }
    }
}