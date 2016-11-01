using EventCourses.Models.Entidades;
using EventCourses.Models.Repositorio;
using EventCourses.Models.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventCourses.Models.Servico
{
    public class Service<T> : IService<T> where T : class
    {
        IUnitOfWork unitOfWork = new Context();
        IRepository<T> _repository;

        public Service()
        {
            _repository = new Repository<T>(unitOfWork);
        }

        public T Find(int id)
        {
            return _repository.Find(id);
        }

        public IQueryable<T> List()
        {
            return _repository.List();
        }

        public void Add(T item)
        {
            _repository.Add(item);
            unitOfWork.Save();
        }

        public void Remove(T item)
        {
            _repository.Remove(item);
            unitOfWork.Save();
        }

        public void Edit(T item)
        {
            _repository.Edit(item);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }


}