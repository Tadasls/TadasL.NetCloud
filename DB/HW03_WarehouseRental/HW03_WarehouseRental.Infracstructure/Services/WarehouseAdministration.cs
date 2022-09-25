using HW03_WarehouseRental.Domains.Models;
using HW03_WarehouseRental.Infracstructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_WarehouseRental.Infracstructure.Services
{
    public class WarehouseAdministration : IWarehouseAdministration
    {
        public void Begin()
        {
            Console.WriteLine("ka noretumete daryti?");
        } 
        public void RegisterRent()
        {
            Console.WriteLine("Print All SalesPerson & Customers");
            Console.WriteLine("Choose One Customer");
            var input = Console.ReadLine();
            //set write input to Customer 
            Console.WriteLine("Set Customer Inventory Size");
            var input2 = Console.ReadLine();
            //set write input to Customer InventorySize if acording gives warehause number

        }

        // Turetu isvesti visus SalesPeople ir Customers, kur turetumete pasirinkti, besinomuojanti Customer
        //  ir jam priskirti agenta, kuris uzbaigs pardavima.Metodo
        //  eigoje vartotojas turetu buti uzklausimas Inventory dydzio
        //  pagal kuri programa nustatys, kuri sandeli priskirti vartotojui.

        public void PrintStatistics()
        {
            Console.WriteLine("Print All SalesPerson ");
            Console.WriteLine("sales person List");
                Console.WriteLine( "Choose One");
                var input = Console.ReadLine();
            Console.WriteLine($"jam {input} priskirtus Customer su jiems priskirtais Warehouses");

        }

        // turetu atspausdinti visus SalesPerson ir
        //  pasirinkus viena is ju turetu isvesti jam priskirtus
        //   Customer su jiems priskirtais Warehouses


    }
}
