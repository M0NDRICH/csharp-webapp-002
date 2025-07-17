using Gamestore.Api.Data;
using Gamestore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Gamestore.Api.Endpoints
{
    public static class GenresEndpoints
    {
        public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("genres");

            group.MapGet("/", async (GameStoreContext dbContext) =>
                await dbContext.Genres
                               .Select(genre => genre.ToDto())
                               .AsNoTracking()
                               .ToListAsync());

            return group;
        }
    }
}
