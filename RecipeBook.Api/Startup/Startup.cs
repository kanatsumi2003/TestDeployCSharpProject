using BusinessLogicLayer.IServices;
using BusinessLogicLayer.Services;
using DataAccessLayer.IRepository;
using DataAccessLayer.Repository;

namespace RecipeBook.Api.Startup;

public class Startup
{
    public IConfiguration _Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        _Configuration = configuration;
    }
    public static void ConfigureServices(IServiceCollection services)
    {
        try
        {
        
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();
        }
        catch (Exception e)
        {
            throw new Exception(e.StackTrace);
        }
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseEndpoints(endpoint =>
        {
            endpoint.MapControllers();
        });
    }
}