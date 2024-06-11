using System;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer : IEntity 
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Id { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public long NationalityId { get; set; }
    }
}