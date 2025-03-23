using flowers_api.Flowers.Dtos;

namespace flowers_api.Flowers.Service
{
    public interface IFLowerCommandService
    {
        Task<FlowerResponse> AddFlower(AddFlowerRequest request);

        Task<FlowerResponse> UpdateFLower(int id, EditFlowerRequest flowerReq);

        Task<FlowerResponse> DeleteFlower(int id);
    }
}
