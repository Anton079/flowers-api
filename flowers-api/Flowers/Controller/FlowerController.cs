using flowers_api.Flowers.Dtos;
using flowers_api.Flowers.Models;
using flowers_api.Flowers.Repository;
using flowers_api.Flowers.Service;
using Microsoft.AspNetCore.Mvc;

namespace flowers_api.Flowers.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FlowerController : ControllerBase
    {
        private IFLowerCommandService _commandService;
        private IFlowerQueryService _queryBuilderService;

        public FlowerController(IFLowerCommandService commandService, IFlowerQueryService queryBuilderService)
        {
            _commandService = commandService;
            _queryBuilderService = queryBuilderService;
        }

        [HttpGet]

        public async Task<ActionResult<List<Flower>>> GetFlowerAsync()
        {
            var flower = await _queryBuilderService.GetAllFlowers();

            return Ok(flower);
        }

        [HttpDelete("deleteFlower")]

        public async Task<ActionResult<FlowerResponse>> DeleteFlowerById([FromQuery] int id)
        {
            var flower = await _commandService.DeleteFlower(id);

            return Ok(flower);
        }

        [HttpPut("UpdateFlower")]

        public async Task<ActionResult<FlowerResponse>> UpdateFlower([FromQuery] int id, [FromBody] EditFlowerRequest flowerReq)
        {
            FlowerResponse flower = await _commandService.UpdateFLower(id, flowerReq);

            return Ok(flower);
        }

        [HttpPost("addFlower")]

        public async Task<ActionResult<FlowerResponse>> AddFlower([FromBody] AddFlowerRequest flowerReq)
        {
            FlowerResponse flower = await _commandService.AddFlower(flowerReq);

            return Ok(flower);
        }
    }
}
