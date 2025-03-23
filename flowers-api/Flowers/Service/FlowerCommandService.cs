using AutoMapper;
using flowers_api.Flowers.Dtos;
using flowers_api.Flowers.Exceptions;
using flowers_api.Flowers.Repository;

namespace flowers_api.Flowers.Service
{
    public class FlowerCommandService : IFLowerCommandService
    {
        private IFlowerRepo _flowerRepo;
        private IMapper _mapper;

        public FlowerCommandService(IFlowerRepo flowerRepo)
        {
            _flowerRepo = flowerRepo;
        }

        public async Task<FlowerResponse> AddFlower(AddFlowerRequest flowerReq)
        {
            if(flowerReq == null) { throw new NullFlowerException(); }

            if(await _flowerRepo.IsFlowerExist(flowerReq)) { throw new FlowerExistException(); }

            FlowerResponse response= await _flowerRepo.CreateFLowerResponseAsync(flowerReq);

            return response;
        }

        public async Task<FlowerResponse> UpdateFLower(int id, EditFlowerRequest flowerReq)
        {
            var existingFlower = await _flowerRepo.FindFlowerByIdAsync(id);

            if(existingFlower == null) { throw new IdExistException(); }

            if(existingFlower.Price == null) { throw new NullPriceException(); }
            if (existingFlower.Type == null) { throw new NullTypeException(); }
            if (existingFlower.Rating == null) { throw new NullRatingException(); }

            FlowerResponse resp = await _flowerRepo.UpdateFlower(id, flowerReq);

            return resp;
        }

        public async Task<FlowerResponse> DeleteFlower(int id)
        {
            if (id <= 0) { throw new IdExpceiton(); }

            var flower = await _flowerRepo.FindFlowerByIdAsync(id);

            if (flower == null) { throw new FlowerExistException(); }

            FlowerResponse resp = await _flowerRepo.DeleteFlowerById(id);

            return resp;
        }
    }
}
