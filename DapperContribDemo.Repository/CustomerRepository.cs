using DapperContribDemo.Repository.Base;
using DapperPoc.Domain.Entities;
using DapperPoc.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace DapperContribDemo.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IConfiguration configuration)
            : base(configuration)
        {
        }
    }
}
