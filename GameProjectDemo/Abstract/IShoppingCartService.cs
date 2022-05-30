using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public interface IShoppingCartService
    {
        void Add(Product product);
        void Delete(Product product);
        void Buy(Product product, Campaign campaign);
    }
}
