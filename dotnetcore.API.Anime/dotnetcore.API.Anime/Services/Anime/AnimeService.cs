using dotnetcore.API.Anime.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore.API.Anime.Services.Anime
{
    public class AnimeService : IAnimeService
    {
        public Task<IEnumerable<Animes>> getAnimes()
        {
            throw new NotImplementedException();
        }
    }
}
