using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class CustomerManager:BaseCustomerManager
    {

        ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Add(Customer customer)
        {
            if ((_customerCheckService.CheckIfRealPerson(customer)).Result)
            {
                base.Add(customer);
            }
            else
            {
                Console.WriteLine("Müşteri eklenmedi.");
            }

        }

        public override void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public override void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
}
    