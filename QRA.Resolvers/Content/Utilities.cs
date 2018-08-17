using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QRA.Repositories.Content;
using System;

namespace QRA.Resolvers.Content
{
    public static class Utilities
    {
        private static Action<DbContextOptionsBuilder, IConfiguration> _action = (optionBuilder, configuration) =>
        {
            optionBuilder
                .UseSqlServer(configuration.GetConnectionString("DevelopmentConnection"),
                    options => options.MigrationsAssembly("QRA.Migrations")
                    .MigrationsHistoryTable("MigrationsHistory", "QRA"));
        };

        public static void RegisterContext<TContexto>(IServiceCollection services, IConfiguration configuration) 
            where TContexto : DbContext
        {
            services.AddDbContext<TContexto>(optionBuilder => _action(optionBuilder, configuration));
        }

        public static void ChangeConfiguration(Action<DbContextOptionsBuilder, IConfiguration> action)
        {
            _action = action;
        }

        //public static void Inicialize(IServiceCollection services, IConfiguration configuration) 
        //{
        //    services.AddDbContext<QRAContext>(optionsBuilder =>
        //        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DevelopmentConnection"),
        //            options => options.MigrationsAssembly("QRA.Migrations")
        //            .MigrationsHistoryTable("MigrationsHistory", "QRA")));
        //}


        //optionsBuilder
        //        .UseSqlServer(configuration.GetConnectionString("DevelopmentConnection"),
        //        options => options.MigrationsAssembly("QRA.Migrations")
        //            .MigrationsHistoryTable("MigrationsHistory", "QRA")

    }
}
