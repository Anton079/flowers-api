using flowers_api.Flowers.Dtos;
using flowers_api.Flowers.Models;

namespace flowers_api.Flowers.Repository
{
    public interface IFlowerRepo
    {
        Task<List<Flower>> GetFlowersAsync();

        Task<List<Flower>> GetMinPrice(int minPrice);

        Task<List<Flower>> GetMinMaxPrice(int min, int max);

        Task<FlowerResponse> DeleteFlowerById(int id);

        Task<FlowerResponse> UpdateFlower(int id, EditFlowerRequest flowerRequest);

        Task<FlowerResponse> CreateFLowerResponseAsync(AddFlowerRequest FlowerReq);

        Task<bool> IsFlowerExist(AddFlowerRequest flowerReq);

        Task<FlowerResponse> FindFlowerByIdAsync(int id);
    }
}
