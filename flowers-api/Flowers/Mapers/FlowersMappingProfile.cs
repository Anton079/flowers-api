using AutoMapper;
using flowers_api.Flowers.Dtos;
using flowers_api.Flowers.Models;

namespace flowers_api.Flowers.Mapers
{
    public class FlowersMappingProfile:Profile
    {
        public FlowersMappingProfile()
        {
            CreateMap<FlowerRequest, Flower>();
            CreateMap<Flower, FlowerResponse>();
        }
    }
}
