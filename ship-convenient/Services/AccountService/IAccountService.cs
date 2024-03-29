﻿using ship_convenient.Core.CoreModel;
using ship_convenient.Model.UserModel;

namespace ship_convenient.Services.AccountService
{
    public interface IAccountService
    {
        Task<ApiResponse<ResponseAccountModel>> Create(CreateAccountModel model);
        Task<ApiResponse<ResponseAccountModel>> GetId(Guid id);
        Task<PaginatedList<ResponseAccountModel>> GetList(int pageIndex, int pageSize);
    }
}
