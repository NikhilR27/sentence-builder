using Application.Mapper;
using Application.Words.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Application.IoC;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));
        services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining(typeof(GetWordTypesQuery)));

        return services;
    }
}