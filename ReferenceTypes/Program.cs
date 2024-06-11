using ReferenceTypes;
using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Tarık";
            person1.Id = 123456;

            
            Customer customer1 = new Customer();
            customer1.Name = person1.Name;
            customer1.Id= person1.Id;
            customer1.CardNumber = "951753654";

            Employee employee1 = new Employee();

            Person person2 = employee1;

            employee1.Name = customer1.Name;

        }
    }
}

