using Domain.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Service
{
    public static class ServiceCollectionsExtentions
    {
        public static void AddFurnitureService(this IServiceCollection services)
        {
            services.AddScoped<INoteInterface, NoteService>();
        }
    }
}
