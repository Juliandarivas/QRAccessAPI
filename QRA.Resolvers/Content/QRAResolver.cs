using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace QRA.Resolvers.Content
{
    public static class QRAResolver 
    {
        public static void Initialize(IServiceCollection services, IConfiguration configuration)
        {
            Utilities.Inicialize(services, configuration);
            
            ////services.Configure<CookiePolicyOptions>(options =>
            ////{
            ////    options.CheckConsentNeeded = context => true;
            ////    options.MinimumSameSitePolicy = SameSiteMode.None;
            ////});

            ////services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            ////services.AddScoped<IMyDependency, MyDependency>();
            ////services.AddTransient<IOperationTransient, Operation>();
            ////services.AddScoped<IOperationScoped, Operation>();
            ////services.AddSingleton<IOperationSingleton, Operation>();
            ////services.AddSingleton<IOperationSingletonInstance>(new Operation(Guid.Empty));

            ////// OperationService depends on each of the other Operation types.
            ////services.AddTransient<OperationService, OperationService>();
        }
    }
}
