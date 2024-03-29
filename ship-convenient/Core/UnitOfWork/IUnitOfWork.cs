﻿using ship_convenient.Core.Context;
using ship_convenient.Core.IRepository;

namespace ship_convenient.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAccountRepository Accounts { get; }
        IConfigRepository Configs { get; }
        IDiscountRepository Discounts { get; }
        IPackageRepository Packages { get; }
        IInfoUserRepository InfoUsers { get; }
        INotificationRepository Notifications { get; }
        IProductRepository Products { get; }
        // IRoleRepository Roles { get; }
        ITransactionRepository Transactions { get; }
        IRouteRepository Routes { get; }
        ITransactionPackageRepository TransactionPackages { get; }
        IVehicleRepository Vehicles { get; }
        Task<int> CompleteAsync();
        int Complete();
    }
}
