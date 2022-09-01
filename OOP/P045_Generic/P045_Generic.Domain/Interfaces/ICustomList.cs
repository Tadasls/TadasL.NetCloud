using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generics.Domain.Interfaces
{
    public interface ICustomList<T>
    {
        public void Add(T itemToAdd);
        public void DeleteNode(T itemtOdELETE);
        public void ProcessAllNodes();

    }
}
