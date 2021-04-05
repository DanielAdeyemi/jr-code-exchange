using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CodeExchange.Models;
using Microsoft.AspNetCore.Identity;

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

      services.AddMvc();
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

      // app.UseHttpsRedirection();

      // global cors policy
      // app.UseCors(x => x
      //   .AllowAnyOrigin()
      //   .AllowAnyMethod()
      //   .AllowAnyHeader());

      // custom jwt auth middleware
      // app.UseMiddleware<JwtMiddleware>();

      app.UseDeveloperExceptionPage();

      app.UseAuthentication(); 


      app.UseRouting();
      app.UseAuthorization();
      app.UseEndpoints(routes =>
      {
        routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
      });

      app.UseStaticFiles();
      
      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Hello World!");
      });
    }
  }
}