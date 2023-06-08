using Microsoft.AspNetCore.Builder;

using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;

using ProductMicroservice.DBContexts;

using ProductMicroservice.Repository;

namespace ProductMicroservice

{

    public class Startup

    {

        public Startup(ConfigurationManager configuration)

        {

            Configuration = configuration;

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)

        {

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)

        {

            services.AddDbContext<ProductContext>(o => o.UseSqlServer(Configuration.GetConnectionString("ProductDB")));

            services.AddTransient<IProductRepository, ProductRepository>();

        }

    }

}