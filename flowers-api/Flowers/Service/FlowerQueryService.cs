using AutoMapper;
using flowers_api.Flowers.Dtos;
using flowers_api.Flowers.Repository;

namespace flowers_api.Flowers.Service
{
    public class FlowerQueryService: IFlowerQueryService
    {
        private IFlowerRepo _repo;
        private IMapper _mapper;

        public FlowerQueryService(IFlowerRepo repo, IMapper mapper)
        {
            this._repo = repo;
            this._mapper = mapper;
        }

        public async Task<List<FlowerResponse>> GetAllFlowers()
        {
            var flower = await _repo.GetFlowersAsync();

            return _mapper.Map<List<FlowerResponse>>(flower);
        }
    }
}
