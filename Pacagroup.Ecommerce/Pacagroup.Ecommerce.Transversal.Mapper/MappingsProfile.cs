using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            // origen, destino
            CreateMap<Customers, CustomersDto>().ReverseMap();

            //CreateMap<Customers, CustomersDto>().ReverseMap()
            //    //v18 minuto 9:00
            //    .ForMember(destination => destination.CustomerID, origen => origen.MapFrom(src => src.CustomerID))
            //    .ForMember(destination => destination.CompanyName, origen => origen.MapFrom(src => src.CompanyName))
            //    .ForMember(destination => destination.ContactName, origen => origen.MapFrom(src => src.ContactName))
            //    .ForMember(destination => destination.ContactTitle, origen => origen.MapFrom(src => src.ContactTitle))
            //    .ForMember(destination => destination.Address, origen => origen.MapFrom(src => src.Address))
            //    .ForMember(destination => destination.City, origen => origen.MapFrom(src => src.City))
            //    .ForMember(destination => destination.Region, origen => origen.MapFrom(src => src.Region))
            //    .ForMember(destination => destination.PostalCode, origen => origen.MapFrom(src => src.PostalCode))
            //    .ForMember(destination => destination.Country, origen => origen.MapFrom(src => src.Country))
            //    .ForMember(destination => destination.Phone, origen => origen.MapFrom(src => src.Phone))
            //    .ForMember(destination => destination.Fax, origen => origen.MapFrom(src => src.Fax));
        }
    }
}