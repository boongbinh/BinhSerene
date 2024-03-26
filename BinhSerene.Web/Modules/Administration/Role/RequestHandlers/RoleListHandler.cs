using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BinhSerene.Administration.RoleRow>;
using MyRow = BinhSerene.Administration.RoleRow;


namespace BinhSerene.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}