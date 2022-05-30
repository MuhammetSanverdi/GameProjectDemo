using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Ürün silindi");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün güncellendi");
        }
    }
}
