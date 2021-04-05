using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CodeExchange.Models
{
  public class CodeExchangeContextFactory : IDesignTimeDbContextFactory<CodeExchangeContext>
  {

    CodeExchangeContext IDesignTimeDbContextFactory<CodeExchangeContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<CodeExchangeContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new CodeExchangeContext(builder.Options);
    }
  }
}