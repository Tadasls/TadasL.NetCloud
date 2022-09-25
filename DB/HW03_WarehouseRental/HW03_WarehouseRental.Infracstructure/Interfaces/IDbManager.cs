using HW03_WarehouseRental.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_WarehouseRental.Domains.Interfaces
{
    public interface IDbManager
    {
        List<SalesPerson> GetSalesPeople();
        List<Customer> GetCustomers();
        List<Warehouse> GetWarehouses();
        void RegisterWareHouseRent(int customerId, int salePersonId, int inventorySize, decimal price);


    }
}
