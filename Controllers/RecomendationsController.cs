using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JikanDotNet;
using AniFun.Services;
using AniFun.Models;

namespace AniFun.Controllers
{
  [ApiController]
  [Route("api/search")]


  public class RecomendationsController : ControllerBase
  {
    [HttpPost]
    [Route("")]

    public async Task<ActionResult<List<AnimeSearchEntry>>> SearchAnime([FromServices] AnimeService jikan, [FromBody] AnimeSearch model)
    {
      if (ModelState.IsValid)
      {
        AnimeSearchResult animeSearchResult = await jikan.SearchAnime(model.Name);
        List<AnimeSearchEntry> animes = new List<AnimeSearchEntry>();


        foreach (var item in animeSearchResult.Results)
        {
          if (item.Type.Equals("TV"))
          {
            animes.Add(item);
          }
        }
        return animes;
      }

      return BadRequest(ModelState);
    }
  }
}