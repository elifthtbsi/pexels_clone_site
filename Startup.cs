using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PexelsDotNetSDK;
using PexelsDotNetSDK.Models;


public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<PexelsService>(provider => new PexelsService("XxfVKnIPRMGUsiObkSBRh99tbO6xPEtDbtOWq4733lxsfCfRIh7eersO"));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
