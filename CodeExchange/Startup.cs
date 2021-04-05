using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
// using CodeExchange.Helpers;
// using CodeExchange.Services;
using CodeExchange.Models;
// using CodeExchange.Interfaces;

namespace CodeExchange
{
	public class Startup
  {
    public Startup(IConfiguration configuration)
  	{
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      // Section for JWT
      // services.AddCors();
      // services.AddControllers();

      // // configure strongly typed settings object
      // services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

      // // configure DI for application services
      // services.AddScoped<IUserService, UserService>();

      services.AddDbContext<CodeExchangeContext>(opt =>
        opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      services.AddControllers();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
  	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      // app.UseHttpsRedirection();

      // global cors policy
      // app.UseCors(x => x
      //   .AllowAnyOrigin()
      //   .AllowAnyMethod()
      //   .AllowAnyHeader());

      // custom jwt auth middleware
      // app.UseMiddleware<JwtMiddleware>();

      app.UseRouting();
      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}