using P045_Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Models
{
    public class EntityRepository<T> : IEntityRepository<T> 
        where T : IUser

    {
        public EntityRepository() { }

        public EntityRepository(List<T> entities)
        {
            _entities = entities;
        }



        private List<T> _entities = new List<T>();
        public void Add(T entity) => _entities.Add(entity);
        public void Remove(T entity) => _entities.Remove(entity);
        public void Print()
        { 
            Console.WriteLine(String.Join(",", _entities));
        }
        public List<T> Fetch() => _entities;
       

        
    }
}
