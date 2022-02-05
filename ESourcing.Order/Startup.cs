using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Ordering.Application;
using Ordering.Application.Handlers;
using Ordering.Infrastructure;
using Ordering.Infrastructure.Data;

namespace ESourcing.Order
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
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IUrlHelper>(factory =>
            {
                var actionContext = factory.GetService<IActionContextAccessor>()
                                           .ActionContext;
                return new UrlHelper(actionContext);
            });


            //services.AddDbContext<AppDbContext>(options =>
            //{
            //    options.UseSqlServer(Configuration["ConnectionStrings:OrderConnection"].ToString(), o =>
            //    {
            //        o.MigrationsAssembly("ESourcing.Infrastructure");
            //        //bunu buraya tanýtmammýn sebebi db contextimin, repositorylerimin hepsnin burada olmasý...
            //    });
            //});
            services.AddControllers();

            #region Add Infrastructure

            services.AddInfrastructure(Configuration);
            services.AddMediatR(typeof(OrderCreateHandler).Assembly);

            #endregion


            services.Configure<ApiBehaviorOptions>(options =>
            {

                options.SuppressModelStateInvalidFilter = true;
            });

            #region Add Application

            services.AddApplication();
            services.AddHttpContextAccessor();
            #endregion

            // Add AutoMapper
            services.AddAutoMapper(typeof(Startup));

            #region EventBus

        

       

            #endregion

            #region Swagger Dependencies

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Order API", Version = "v1" });
            });

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

       

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Order API V1");
            });

            app.UseDeveloperExceptionPage();
        }
    }
}
