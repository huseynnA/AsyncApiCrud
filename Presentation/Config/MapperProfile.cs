using AutoMapper;
using DataAccess.Entity;
using DTO;
namespace Presentation.Config
{
    public class MapperProfile:Profile
    {
        MapperProfile() 
        {
            CreateMap<DataAccess.Entity.Host, HostDTO>();
            CreateMap<HostDTO, DataAccess.Entity.Host>();

            CreateMap<Query, QueryDTO>();
            CreateMap<QueryDTO, Query>();
        }
    }
}
