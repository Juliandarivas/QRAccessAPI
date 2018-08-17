using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QRA.Repositories.Content;

namespace QRA.Resolvers.Content
{
    public static class QRAResolver 
    {
        public static void Initialize(IServiceCollection services, IConfiguration configuration)
        {
            InitializeContext(services, configuration);
            //InitializeRepositories(services);
            //InitializeServices(services);
            //InitializeDomains(services);
            //InitializeApplications(services);
        }
        private static void InitializeContext(IServiceCollection services, IConfiguration configuration)
        {
            Utilities.RegisterContext<QRAContext>(services, configuration);
        }
        private static void InitializeRepositories(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
        private static void InitializeServices(IServiceCollection services)
        {
            throw new NotImplementedException();
        }
        private static void InitializeDomains(IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        private static void InitializeApplications(IServiceCollection services)
        {
            throw new NotImplementedException();
        }

    }
}
