using flowers_api.Flowers.Models;

namespace flowers_api.Flowers.Repository
{
    public interface IFlowerRepo
    {
        Task<List<Flower>> GetFlowersAsync();
    }
}
