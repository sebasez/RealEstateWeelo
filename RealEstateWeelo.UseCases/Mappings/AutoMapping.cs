using AutoMapper;
using RealEstateWeelo.DTOs;
using RealEstateWeelo.Entities.POCOs;

namespace RealEstateWeelo.UseCases.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CreatePropertyDTO, Property>().ReverseMap();
            CreateMap<Property, PropertyDTO>().ReverseMap();
            CreateMap<UpdatePropertyDTO, Property>().ReverseMap();
            CreateMap<CreateOwnerDTO, Owner>().ReverseMap();
            CreateMap<Owner, OwnerDTO>().ReverseMap();
            CreateMap<CreatePropertyImageDTO, PropertyImage>().ReverseMap();
            CreateMap<PropertyImage, PropertyImageDTO>().ReverseMap();
        }
    }
}
