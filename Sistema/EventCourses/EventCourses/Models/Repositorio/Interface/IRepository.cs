﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCourses.Models.Repositorio
{
    public interface IRepository<T> where T : class
    {
        T Find(int id);
        IQueryable<T> List();
        void Add(T item);
        void Remove(T item);
        void Edit(T item);
        void Dispose();


    }
}
