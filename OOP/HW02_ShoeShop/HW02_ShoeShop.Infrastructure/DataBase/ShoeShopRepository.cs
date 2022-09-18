using HW02_ShoeShop.Domais.Models;
using HW02_ShoeShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02_ShoeShop.Infrastructure.DataBase
{
    public class ShoeShopRepository : IShoeShopRepository
    {
        public List<Sale> GetAllPurchases()
        {
            throw new NotImplementedException();
        }

        public List<Shoe> GetAllShoes()
        {
            throw new NotImplementedException();
        }

        public void MakePurchaseAndReduceQuantity(int shoeSizeId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
