using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCourses.Models.Entidades
{
    public interface IUnitOfWork
    {

        void Save();

    }
}
