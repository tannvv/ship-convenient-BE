﻿using ship_convenient.Core.CoreModel;
using ship_convenient.Model.RouteModel;

namespace ship_convenient.Services.RouteService
{
    public interface IRouteService
    {
        Task<ApiResponse<List<ResponseRouteModel>>> GetRouteUserId(Guid infoUserId);
        Task<ApiResponse> SetActiveRoute(Guid routeId);
        Task<ApiResponse<ResponseRouteModel>> Create(CreateRouteModel model);
    }
}
