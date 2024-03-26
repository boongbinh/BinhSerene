using MyRequest = Serenity.Services.SaveRequest<BinhSerene.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = BinhSerene.Administration.LanguageRow;


namespace BinhSerene.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}