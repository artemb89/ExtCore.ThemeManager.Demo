using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExtCore.ThemeManager.Demo
{
    public class Startup: ExtCore.WebApplication.Startup
    {
        public Startup(IServiceProvider serviceProvider)
      : base(serviceProvider)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
              .SetBasePath(this.serviceProvider.GetService<IHostingEnvironment>().ContentRootPath)
              .AddJsonFile("config.json", optional: true, reloadOnChange: true);

            this.configurationRoot = configurationBuilder.Build();
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);         
        }

        public override void Configure(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseBrowserLink();
            applicationBuilder.UseDeveloperExceptionPage();
            applicationBuilder.UseDatabaseErrorPage();
            
            base.Configure(applicationBuilder);
        }
    }
}
