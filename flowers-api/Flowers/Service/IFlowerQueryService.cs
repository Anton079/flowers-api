using flowers_api.Flowers.Dtos;

namespace flowers_api.Flowers.Service
{
    public interface IFlowerQueryService
    {
        Task<List<FlowerResponse>> GetAllFlowers();
    }
}
