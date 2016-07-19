using AutoMapper;
using ErpOne.Domain.Entities;
using ErpOne.MVC.ViewModels;

namespace ErpOne.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();

        }
    } 
   
}