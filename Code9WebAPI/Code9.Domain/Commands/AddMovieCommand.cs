using Code9.Domain.Models;
using MediatR;

namespace Code9.Domain.Commands
{
    public record AddMovieCommand : IRequest<Movie>
    {
        public string Title { get; set; }
        public string ReleaseYear { get; set; }
        public int Rating { get; set; }
    }
}
