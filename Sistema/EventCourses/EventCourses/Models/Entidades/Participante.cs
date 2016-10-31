using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Entidades
{
    public class Participante
    {

        public Participante()
        {

            this.Formacao = new List<Formacao>();

        }


        public String Nome { get; set; }

        public String Cpf { get; set; }

        public String Email { get; set; }

        public virtual IList<Formacao> Formacao { get; set; }

        public int FormacaoId { get; set; }


    }
}