using GameProjectDemo.Abstract;
using GameProjectDemo.Adapter;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.ProductName = "God Of War";
            product.UnitsInStock = 5;
            product.UnitPrice = 500;

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Muhammet Can";
            customer.LastName = "Şanverdi";
            customer.NationalityId = "30361705184";
            customer.DateOfBirth = new DateTime(1998,11,29);

            ICustomerCheckService customerCheckService = new MernisCheckManager();


            CustomerManager customerManager = new CustomerManager(customerCheckService);
            customerManager.Add(customer);
        }

    }
}
