using dotnetcore.API.Anime.BusinessObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnetcore.API.Anime.Services.Anime
{
    public interface IAnimeService
    {
        Task<IEnumerable<Animes>> getAnimes();
    }
}
