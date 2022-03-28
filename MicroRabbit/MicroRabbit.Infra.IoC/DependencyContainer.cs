using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //DOMAIN BUS
            services.AddTransient<IEventBus, RabbitMQBus>();

            //APPLICATION SERVICES
            services.AddTransient<IAccountService, AccountService>();

            //DATA
            services.AddTransient<IAccountRepository, AccountRepository>();
            
            services.AddTransient<BankingDbContext>();
        }
    }
}
