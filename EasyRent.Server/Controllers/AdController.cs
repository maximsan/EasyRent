using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Models.AdModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyRent.Server.Controllers
{
    [Authorize]
    [Route("ads")]
    public class AdController : BaseController
    {
        private readonly IAdService adService;

        public AdController(IAdService adService)
        {
            this.adService = adService;
        }

        [HttpGet("ad/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var model = await adService.GetByIdAsync(id);

            return OkOrNotFound(model);
        }

        public async Task<IActionResult> Search([FromQuery, FromBody] AdRequest request)
        {
            if (request is null)
            {
                return BadRequest();
            }

            var result = await adService.SearchAsync(request);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Put([FromBody] AdModel model)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            if (model.AdId == 0)
            {
                var result = await adService.CreateAsync(model);

                if (result is null)
                {
                    return BadRequest();
                }
                
                return CreatedAtAction(Url.Content($"~/ads/ad/{result.AdId}"), result);
            }
            else
            {
                await adService.UpdateAsync(model);
                return Ok(model);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            await adService.DeleteAsync(id);

            return Ok();
        }
    }
}