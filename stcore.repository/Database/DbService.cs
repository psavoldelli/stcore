using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace stcore.repository.Database
{
    public static  class DbService
    {
        public static void AddDatabase(this IServiceCollection services,string name)
        {
            services.AddTransient<DbContext, DbContext>();
            services.Configure<DbOptions>(options => options.Name = name);
        }
    }
}