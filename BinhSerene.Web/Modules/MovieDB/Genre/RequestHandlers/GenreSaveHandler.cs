using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<BinhSerene.MovieDB.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BinhSerene.MovieDB.GenreRow;

namespace BinhSerene.MovieDB;

public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
{
    public GenreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}