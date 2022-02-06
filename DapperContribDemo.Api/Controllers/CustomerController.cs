using AutoMapper;
using DapperContribDemo.Api.Request;
using DapperContribDemo.Api.Response;
using DapperPoc.Domain.Entities;
using DapperPoc.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DapperContribDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(
            ICustomerService customerService,
            IMapper mapper
        )
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<CustomerResponse> GetAllCostumer()
        {
            var response = _mapper.Map<IEnumerable<CustomerResponse>>(_customerService.GetAllCustomer());

            return response;
        }

        [HttpGet("{id}")]
        public CustomerResponse GetCostumer(int id)
        {
            return _mapper.Map<CustomerResponse>(_customerService.GetCustomerById(id));
        }

        [HttpPost]
        public CustomerResponse CreateCustomer(CustomerRequest request)
        {
            var customer = _mapper.Map<Customer>(request);

            return _mapper.Map<CustomerResponse>(_customerService.Create(customer));
        }
    }
}
