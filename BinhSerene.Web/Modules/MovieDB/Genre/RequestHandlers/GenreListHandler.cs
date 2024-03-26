using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BinhSerene.MovieDB.GenreRow>;
using MyRow = BinhSerene.MovieDB.GenreRow;

namespace BinhSerene.MovieDB;

public interface IGenreListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class GenreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenreListHandler
{
    public GenreListHandler(IRequestContext context)
            : base(context)
    {
    }
}