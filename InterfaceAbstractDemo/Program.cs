using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FName = "tarık";
            customer.LName = "yördem";
            customer.DateOfBirth = new DateTime(2001,05,29);
            customer.Id = 1546521;
            customer.NationalityId = "123456879"; 
            BaseCustomerManager customerManager = new NeroCustomerManager();
            //BaseCustomerManager customerManager1 = new StarbucksCustomerManager();
            customerManager.Save(customer);
            //customerManager1.Save(customer2);
        }
    }

}