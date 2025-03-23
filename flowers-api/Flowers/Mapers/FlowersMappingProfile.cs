using AutoMapper;
using flowers_api.Flowers.Dtos;
using flowers_api.Flowers.Models;

namespace flowers_api.Flowers.Mapers
{
    public class FlowersMappingProfile:Profile
    {
        public FlowersMappingProfile()
        {
            CreateMap<AddFlowerRequest, Flower>();
            CreateMap<EditFlowerRequest, Flower>();
            CreateMap<DeleteFlowerRequest, Flower>();
            CreateMap<Flower, FlowerResponse>();
        }
    }
}
