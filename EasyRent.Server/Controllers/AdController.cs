using EasyRent.Common.Interfaces;
using EasyRent.Common.Models.AdModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyRent.Server.Controllers
{
    [Authorize]
    public class AdController : BaseController
    {
        private readonly IAdService adService;

        public AdController(IAdService adService)
        {
            this.adService = adService;
        }

        public async Task<IActionResult> Search([FromQuery, FromBody] AdRequest request)
        {
            if (request is null)
            {
                return BadRequest();
            }

            var result = await adService.Search(request);

            return Ok(result);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> Put([FromBody] AdModel model)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            if (model.AdId == 0)
            {
                await adService.Create(model);
            }
            else
            {
                await adService.Update(model);
            }

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            await adService.Delete(id);

            return Ok();
        }
    }
}