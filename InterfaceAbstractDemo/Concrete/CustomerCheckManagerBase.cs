using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    internal class CustomerCheckManagerBase : ICustomerCheckService
    {
        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}