using Application.Logics.Base;
using AutoMapper;
using Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ShoppingSystem;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    private IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        });
        
        services.AddScoped(typeof(IBaseCrudLogic<>), typeof(BaseCrudLogic<>));
        
        var mapperConfiguration = new MapperConfiguration(config =>
        {
            config.AddMaps(typeof(BaseCrudLogic<>).Assembly);
        });
        
        var mapper = mapperConfiguration.CreateMapper();
        services.AddSingleton(mapper);
    }

    public void Configure(IApplicationBuilder builder, IWebHostEnvironment environment)
    {
        if (environment.IsDevelopment())
        {
            builder.UseSwagger();
            builder.UseSwaggerUI();
        }

        builder.UseRouting();
        
        builder.UseHttpsRedirection();

        builder.UseAuthorization();

        builder.UseEndpoints(endpoint => endpoint.MapControllers());
    }
}