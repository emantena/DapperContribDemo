using AutoMapper;
using DapperContribDemo.Api.Request;
using DapperPoc.Domain.Entities;

namespace DapperContribDemo.Api.Mapper
{
    public class RequestToDomainMappingProfile : Profile
    {
        public RequestToDomainMappingProfile()
        {
            CreateMap<CustomerRequest, Customer>();
        }
    }
}