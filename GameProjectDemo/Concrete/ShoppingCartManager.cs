using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class ShoppingCartManager : IShoppingCartService
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Sepetten silindi.");
        }

        public void Buy(Product product,Campaign campaign)
        {
            var finalPrice = product.UnitPrice - campaign.Discount;
            if (finalPrice>0)
            {
                Console.WriteLine(product.ProductName + " adlı oyununu " + finalPrice + " TL fiyata aldınız.");
                product.UnitsInStock = product.UnitsInStock - 1;
            }
            else
            {
                Console.WriteLine("İndirim tutarı ürün tutarını aştı.");
            }
            
        }
    }
}
