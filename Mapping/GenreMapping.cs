using Gamestore.Api.Dtos;
using Gamestore.Api.Entities;

namespace Gamestore.Api.Mapping
{
    public static class GenreMapping
    {
        public static GenreDto ToDto(this Genre genre)
        {
            return new GenreDto(genre.Id, genre.Name);
        }
    }
}
