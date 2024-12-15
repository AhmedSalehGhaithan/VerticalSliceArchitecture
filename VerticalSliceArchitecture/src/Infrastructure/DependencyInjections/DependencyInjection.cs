using Mapster;
using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.src.Common.Exceptions;
using VerticalSliceArchitecture.src.Feature.Product.Mapping;
using VerticalSliceArchitecture.src.Infrastructure.Data;
namespace VerticalSliceArchitecture.src.Infrastructure.DependencyInjections;

public static class DependencyInjection
{
    public static IServiceCollection AddAppService(this IServiceCollection services, IConfiguration _conf)
    {
        services.AddExceptionHandler<GlobalExceptionHandler>();

        services.AddMediatR(confg => confg.RegisterServicesFromAssembly(typeof(Program).Assembly));

        TypeAdapterConfig.GlobalSettings.Scan(typeof(GetProductMappingConfig).Assembly);

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(_conf.GetConnectionString("DefaultConnection"));
        });

        return services;
    }
}
