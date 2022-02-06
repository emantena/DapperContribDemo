using DapperContribDemo.Domain.Entities;
using System.Collections.Generic;

namespace DapperContribDemo.Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        Customer Create(Customer customer);
    }
}
