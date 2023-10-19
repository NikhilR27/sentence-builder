using Application.Words.Queries;
using Application.Words.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
public class WordController : ControllerBase
{
    private readonly IMediator _mediator;

    public WordController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<GetWordsResponse>> GetWords(GetWordsQuery query)
    {
        return await _mediator.Send(query);
    }
}