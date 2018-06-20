using AutoMapper;
using Liu.Application.ViewModels;
using Liu.Domain.Models;

namespace Liu.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}
