using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BinhSerene.MovieDB.MovieGenresRow>;
using MyRow = BinhSerene.MovieDB.MovieGenresRow;

namespace BinhSerene.MovieDB;

public interface IMovieGenresListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class MovieGenresListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresListHandler
{
    public MovieGenresListHandler(IRequestContext context)
            : base(context)
    {
    }
}