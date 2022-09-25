using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_WarehouseRental.Infracstructure.Interfaces
{
    public interface IWarehouseAdministration
    {
        void Begin(); 
        void RegisterRent();
        void PrintStatistics();
    }
}
