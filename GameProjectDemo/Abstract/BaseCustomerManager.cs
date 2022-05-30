using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {      
        public  virtual void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " adlı müşteri eklendi.");

        }

        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
}
