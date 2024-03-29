﻿using ship_convenient.Core.Context;
using ship_convenient.Core.UnitOfWork;
using ship_convenient.Services.AccountService;
using ship_convenient.Services.AuthorizeService;
using ship_convenient.Services.GoongService;
using ship_convenient.Services.MapboxService;
using ship_convenient.Services.RouteService;

namespace ship_convenient.Config
{
    public static class DIServiceExtension
    {
        public static void AddDIService(this IServiceCollection services) {
            services.AddDbContext<AppDbContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IGoongService, GoongService>();
            services.AddTransient<IMapboxService, MapboxService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAuthorizeService, AuthorizeService>();
            services.AddTransient<IRouteService, RouteService>();
        }
    }
}
