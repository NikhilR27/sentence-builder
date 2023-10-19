using Application.Words.Queries;
using Application.Words.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

public class WordController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<GetWordsResponse>> GetWords([FromQuery] GetWordsQuery query)
    {
        return await Mediator.Send(query);
    }
}