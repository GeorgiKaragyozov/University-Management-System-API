namespace University_Management_System_API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.HttpsPolicy;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using University_Management_System_API.Authentication.Common;
    using University_Management_System_API.Extensions.Common;

    public class Startup
    {
        public Startup(IConfiguration configuration) => this.Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var SaltSettingsSercret = Configuration.GetSection("SecretKeySettings");
            services.Configure<SecretKeySettings>(SaltSettingsSercret);

            services.AddControllers();

            services.AddDbContext<UniversityManagementSystemContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString(
                        "University-Management-System-Default"))
                            .UseLazyLoadingProxies());

            // Injection of all objects
            BaseRegisterExtensions.BaseRegisterDependencies(services);

            //services.AddSwaggerDocumentation();

            //Enable cors
            services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
            {
                builder.WithOrigins("http://localhost:4200")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
            }));

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //SwaggerServiceExtensions.UseSwaggerDocumentation(app);

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseCors("ApiCorsPolicy");

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
