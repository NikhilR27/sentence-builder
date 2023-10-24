using Application.Sentences.Commands;
using Application.Sentences.Queries;
using Application.Sentences.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

public class SentenceController : BaseApiController
{
    [HttpPost]
    public async Task<ActionResult<SaveSentenceResponse>> PostSentence([FromBody] SaveSentenceCommand command)
    {
        var response = await Mediator.Send(command);
        return response.SaveSuccessful switch
        {
            true => Ok(response),
            _ => Problem()
        };
    }

    [HttpGet]
    public async Task<ActionResult<GetAllSentencesResponse>> GetAllSentences([FromQuery] GetAllSentencesQuery query)
    {
        return Ok(await Mediator.Send(query));
    }
}