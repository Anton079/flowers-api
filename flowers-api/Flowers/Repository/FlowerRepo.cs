using AutoMapper;
using flowers_api.Data.Migrations;
using flowers_api.Flowers.Dtos;
using flowers_api.Flowers.Models;
using Microsoft.EntityFrameworkCore;

namespace flowers_api.Flowers.Repository
{
    public class FlowerRepo : IFlowerRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public FlowerRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<Flower>> GetFlowersAsync()
        {
            return await _appDbContext.Flowers.ToListAsync();
        }

        public async Task<FlowerResponse> CreateFLowerResponseAsync(AddFlowerRequest FlowerReq)
        {
            Flower flower = _mapper.Map <Flower>(FlowerReq);

            _appDbContext.Flowers.Add(flower);

            await _appDbContext.SaveChangesAsync();

            FlowerResponse response = _mapper.Map<FlowerResponse>(flower);

            return response;
        }

        public async Task<List<Flower>> GetMinPrice(int minPrice)
        {
            return await _appDbContext.Flowers.Where(flower => flower.price > minPrice).ToListAsync();
        }

        public async Task<List<Flower>> GetMinMaxPrice(int min , int max)
        {
            return await _appDbContext.Flowers.Where(flower => flower.price > min && flower.price < max).ToListAsync();
        }

        public async Task<FlowerResponse> DeleteFlowerById(int id)
        {
            Flower flower = await _appDbContext.Flowers.FindAsync(id);

            FlowerResponse flowerResponse = _mapper.Map<FlowerResponse>(flower);

            _appDbContext.Flowers.Remove(flower);

            await _appDbContext.SaveChangesAsync();

            return flowerResponse;
        }

        public async Task<FlowerResponse> UpdateFlower(int id, EditFlowerRequest flowerRequest)
        {
            var flower = await _appDbContext.Flowers.FindAsync(id);


            flower.type = flowerRequest.Type ?? flower.type;
            flower.price = flowerRequest.Price ?? flower.price;
            flower.rating = flowerRequest.Rating ?? flower.rating;

            _appDbContext.Flowers.Update(flower);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<FlowerResponse>(flower);


        }

        public async Task<bool> IsFlowerExist(AddFlowerRequest flowerReq)
        {
            return await _appDbContext.Flowers.AnyAsync(c => c.type == flowerReq.Type);
        }

        public async Task<FlowerResponse> FindFlowerByIdAsync(int id)
        {
            var flower = await _appDbContext.Flowers.FirstOrDefaultAsync(c => c.id == id);

            return _mapper.Map<FlowerResponse>(flower);
        }

    }
}
