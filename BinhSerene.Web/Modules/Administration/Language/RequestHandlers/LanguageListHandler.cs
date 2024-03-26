using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BinhSerene.Administration.LanguageRow>;
using MyRow = BinhSerene.Administration.LanguageRow;


namespace BinhSerene.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}