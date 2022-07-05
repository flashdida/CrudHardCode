using Application.Logics;
using Application.Logics.Base;

namespace ShoppingSystem;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseCrudLogic<>), typeof(BaseCrudLogic<>));
    }
}