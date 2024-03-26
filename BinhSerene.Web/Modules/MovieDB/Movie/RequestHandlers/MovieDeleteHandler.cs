using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = BinhSerene.MovieDB.MovieRow;

namespace BinhSerene.MovieDB;

public interface IMovieDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class MovieDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieDeleteHandler
{
    public MovieDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}