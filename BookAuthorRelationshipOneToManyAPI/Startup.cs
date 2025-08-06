using BookAuthorRelationshipOneToManyAPI.Data;
using BookAuthorRelationshipOneToManyAPI.Entities;
using BookAuthorRelationshipOneToManyAPI.Repositories;
using BookAuthorRelationshipOneToManyAPI.Services;
using BookAuthorRelationshipOneToManyAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace BookAuthorRelationshipOneToManyAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BookAuthorAPI", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());


            });

            services.AddDbContext<BookAuthorDbContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookServices, BookServices>();
            services.AddScoped<IExceptionList, ExceptionList>();

        }
     
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseStaticFiles();
                app.UseDeveloperExceptionPage();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookAuthorAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            
            app.UseDeveloperExceptionPage();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
            
        }
    }
}
