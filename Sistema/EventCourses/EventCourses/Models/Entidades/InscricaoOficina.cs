using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Entidades
{
    public class InscricaoOficina
    {

        public int Id { get; set; }

        public virtual Oficina Oficina { get; set; }

        public int OficinaId { get; set; }

        public Participante Participante { get; set; }

        public int ParticipanteId { get; set; }
    }
}