using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductProperties { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
