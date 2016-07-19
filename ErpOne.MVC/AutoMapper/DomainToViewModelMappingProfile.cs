using AutoMapper;
using ErpOne.Domain.Entities;
using ErpOne.MVC.ViewModels;

namespace ErpOne.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}