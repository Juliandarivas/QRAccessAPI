using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QRA.Repositories.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace QRA.Resolvers.Content
{
    public static class Utilities
    {
        public static void Inicialize(IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<QRAContext>(optionsBuilder =>
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DevelopmentConnection"),
                    options => options.MigrationsAssembly("QRA.Migrations")
                    .MigrationsHistoryTable("MigrationsHistory", "QRA")));
        }
    }
}
