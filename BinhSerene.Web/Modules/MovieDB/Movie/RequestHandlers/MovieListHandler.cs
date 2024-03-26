﻿using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<BinhSerene.MovieDB.MovieRow>;
using MyRow = BinhSerene.MovieDB.MovieRow;

namespace BinhSerene.MovieDB;

public interface IMovieListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class MovieListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieListHandler
{
    public MovieListHandler(IRequestContext context)
            : base(context)
    {
    }
}