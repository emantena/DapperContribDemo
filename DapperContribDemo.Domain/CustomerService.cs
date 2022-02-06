using DapperContribDemo.Domain.Entities;
using DapperContribDemo.Domain.Interfaces.Repositories;
using DapperContribDemo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DapperContribDemo.Domain
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Customer Create(Customer customer)
        {
            _repository.Save(customer);
            
            return customer;
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _repository.GetAll();
        }

        public Customer GetCustomerById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
