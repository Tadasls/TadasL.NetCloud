using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Interfaces
{
    public interface IEntityRepository
    {
        void Add();
        void Remove();
        void Print();
        void Fetch();
    }
}
