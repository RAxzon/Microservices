using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infrastructure.IoC
{
    // Bind interfaces with concrete types
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
