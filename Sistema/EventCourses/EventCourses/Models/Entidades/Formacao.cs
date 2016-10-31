using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Entidades
{
    public class Formacao
    {

        public int Id { get; set; }

        public String NivelFormacao { get; set; }

        public String LocalEnsino { get; set; }

        public int Duracao { get; set; }

        public Boolean Completo { get; set; }


    }
}