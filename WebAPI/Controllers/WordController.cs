using Application.Words.Queries;
using Application.Words.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

public class WordController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<GetWordTypesResponse>> GetWordTypes([FromQuery] GetWordTypesQuery query)
    {
        return Ok(await Mediator.Send(query));
    }
}