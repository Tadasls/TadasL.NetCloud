﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Interfaces
{
    public interface IEntityRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
        void Print();
        List<T> Fetch();
    }
}
