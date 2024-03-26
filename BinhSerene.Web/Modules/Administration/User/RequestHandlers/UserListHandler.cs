using MyRequest = BinhSerene.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<BinhSerene.Administration.UserRow>;
using MyRow = BinhSerene.Administration.UserRow;

namespace BinhSerene.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}