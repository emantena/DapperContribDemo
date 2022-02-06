using AutoMapper;
using DapperContribDemo.Api.Response;
using DapperPoc.Domain.Entities;

namespace DapperContribDemo.Api.Mapper
{
    public class DomainToResponseMappingProfile : Profile
    {
        public DomainToResponseMappingProfile()
        {
            CreateMap<Customer, CustomerResponse>();
        }
    }
}