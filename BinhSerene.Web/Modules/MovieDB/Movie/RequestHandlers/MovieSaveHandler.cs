using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BinhSerene.MovieDB.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BinhSerene.MovieDB.MovieRow;

namespace BinhSerene.MovieDB;

public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
{
    public MovieSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}