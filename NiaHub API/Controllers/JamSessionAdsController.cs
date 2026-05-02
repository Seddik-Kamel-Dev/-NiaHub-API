using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NiaHub_API.DTOs;
using NiaHub_API.Mappers;
using NiaHub_API.Repository;

namespace NiaHub_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JamSessionAdsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<JamSessionAdDto>> Get()
        {
            
            var result = FakeData.Ads.Select(ad =>
            {
                return JamSessionAdMapper.ToDto(ad);
            }).ToList();

            return Ok(result);
        }
    }
}
