using GoEdu.Data;
using Microsoft.AspNetCore.Mvc;
using GoEdu.Repositories;
using Microsoft.EntityFrameworkCore;
using GoEdu.Hubs;

namespace GoEdu
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // add context
            builder.Services.AddDbContext<GoEduContext>(option => {
                option.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            });
            //register unit of work 
            builder.Services.AddScoped<UnitOfWork, UnitOfWork>();

            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });

            builder.Services.AddSignalR();
            // SignalR Service for external applications and pages
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(url => true)
                    .AllowCredentials();

                });
            });



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapHub<CommentHub>("/CommentHub");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
