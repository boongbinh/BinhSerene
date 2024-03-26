using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<BinhSerene.MovieDB.MovieGenresRow>;
using MyRow = BinhSerene.MovieDB.MovieGenresRow;

namespace BinhSerene.MovieDB;

public interface IMovieGenresRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class MovieGenresRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresRetrieveHandler
{
    public MovieGenresRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}