using P045_Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Models
{
    public class EntityRepository<T> where T : IEntityRepository
    {
        public EntityRepository()
        {

        }



        private List<T> trysDalykai;

    }
}
