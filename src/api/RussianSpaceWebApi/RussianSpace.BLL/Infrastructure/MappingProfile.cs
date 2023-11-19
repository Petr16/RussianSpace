using AutoMapper;
using RussianSpace.BLL.ViewModels;
using RussianSpace.DAL.Entities;

namespace RussianSpace.BLL.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Request, RequestVM>();
            //CreateMap<RequestVM, Request>();
            CreateMap<Request, RequestVM>().ReverseMap();

            //CreateMap<Customer, CustomerVM>().ReverseMap();

            //CreateMap<StatusRequest, StatusRequestVM>().ReverseMap();
        }
    }
}
