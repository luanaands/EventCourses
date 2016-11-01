using EventCourses.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace EventCourses.Models.Servico.Interface
{
    public class MinistranteService : Service<Ministrante>, IMinistranteService
    {
        private ModelStateDictionary _modelState;

        public MinistranteService(ModelStateDictionary modelState)
        {
            _modelState = modelState;
        }

        public bool Validate(Ministrante item)
        {
            if (item.Id == 0)
            {
                if (this.List().Where(c => c.Cpf == item.Cpf).Count() > 0)
                    _modelState.AddModelError("Name", "Perfil já cadastrado");
            }

            return _modelState.IsValid;
        }


        
    }
}