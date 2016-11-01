using EventCourses.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCourses.Models.Servico.Interface
{
    public interface IMinistranteService : IService<Ministrante>, IDisposable
    {
        bool Validate(Ministrante ministrante);
    }
}
