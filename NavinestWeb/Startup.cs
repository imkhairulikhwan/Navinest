using Microsoft.Owin;
using Owin;
using NavinestWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: OwinStartupAttribute(typeof(NavinestWeb.Startup))]
namespace NavinestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
		
		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();

			var connection = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-NavinestWeb-20180212103628.mdf;Initial Catalog=aspnet-NavinestWeb-20180212103628;Integrated Security=True";
			services.AddDbContext<BloggingContext>(options => options.UseSqlServer(connection));
		}
	}
}
