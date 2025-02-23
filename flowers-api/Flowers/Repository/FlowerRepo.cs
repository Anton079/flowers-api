using AutoMapper;
using flowers_api.Data.Migrations;
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
    }
}
