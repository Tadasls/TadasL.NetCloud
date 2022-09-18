using HW02_ShoeShop.Domais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_ShoeShop.Infrastructure.Interfaces
{
    public interface IShoeShopRepository
    {

        public List<Shoe> GetAllShoes();
        public void MakePurchaseAndReduceQuantity(int shoeSizeId, int quantity);
        public List<Sale> GetAllPurchases();



    }
}
