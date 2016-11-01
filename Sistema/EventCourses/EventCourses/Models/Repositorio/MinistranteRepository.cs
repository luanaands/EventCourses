using EventCourses.Models.Entidades;
using EventCourses.Models.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Repositorio
{
    public class MinistranteRepository :Repository<Ministrante>, IMinistranteRepository
    {
        IUnitOfWork unitOfWork = new Context();

        public MinistranteRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

    }
}