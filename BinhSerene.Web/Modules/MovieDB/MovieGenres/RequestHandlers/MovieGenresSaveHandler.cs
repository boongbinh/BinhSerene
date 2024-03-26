using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BinhSerene.MovieDB.MovieGenresRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BinhSerene.MovieDB.MovieGenresRow;

namespace BinhSerene.MovieDB;

public interface IMovieGenresSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class MovieGenresSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresSaveHandler
{
    public MovieGenresSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}