using AutoMapper;
using BuisnessLogic.DTO;
using DataAccess.Models;

namespace ReviewProject
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ImageModel, ImageModelDTO>();
            CreateMap<ImageModelDTO, ImageModel>(); 
        }
    }

}
