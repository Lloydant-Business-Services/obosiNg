using Microsoft.EntityFrameworkCore;
using Obosi.ng.Data;

namespace Obosi.ng.Presentation.utility
{
    public static class DbInitializerExtension
    {
        public static async Task<IApplicationBuilder> PrepareDatabase(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var serviceProvider = scopedServices.ServiceProvider;
            var data = serviceProvider.GetRequiredService<DataContext>();

            data.Database.Migrate();
            return app;
        }
    }

}
