using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCabinRental.Database;
using eCabinRental.Model.Request.Grad;
using eCabinRental.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace eCabinRental
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
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddDbContext<BSContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IObjekatService, ObjekatService>();
            //services.AddScoped<IGradService, GradService>();
            services.AddScoped<IService<Model.Grad, GradSearchRequest>, GradService>();
            services.AddScoped<IOcjenaService, OcjenaService>();
            services.AddScoped<ITipObjektumService, TipObjektumService>();
            services.AddScoped<IDetaljiRezervacijeService, DetaljiRezervacijeService>();
            services.AddScoped<IKlijentService, KlijentService>();
            services.AddScoped<IRezervacijaService, RezervacijaService>();
            services.AddScoped<IUlogaService, UlogaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
           {
               c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
           });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
