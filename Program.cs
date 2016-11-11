using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace WebApplication4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder().UseKestrel().UseStartup<Startup>().Build().Run();
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet("{name}")]
        public IEnumerable<string> Get(string name)
        {
            return new [] { name + "-foo", name + "-bar" };
        }
    }
}
