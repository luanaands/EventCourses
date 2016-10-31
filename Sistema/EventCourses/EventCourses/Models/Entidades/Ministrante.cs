using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Entidades
{
    public class Ministrante
    {

        public Ministrante()
        {

            this.Formacao = new List<Formacao>();

        }

        public String Nome { get; set;}

        public String Cpf { get; set; }

        public String Especialidade { get; set; }

        public virtual IList<Formacao> Formacao { get; set; }

        public  int FormacaoId { get; set; }



    }
}