using flowers_api.Flowers.Models;
using flowers_api.Flowers.Repository;
using Microsoft.AspNetCore.Mvc;

namespace flowers_api.Flowers.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FlowerController : ControllerBase
    {
        private IFlowerRepo _flowerRepo;

        public FlowerController(IFlowerRepo flowerRepo)
        {
            _flowerRepo = flowerRepo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Flower>>> GetFlowerAsync()
        {
            var flower = await _flowerRepo.GetFlowersAsync();

            return Ok(flower);
        }
    }
}
