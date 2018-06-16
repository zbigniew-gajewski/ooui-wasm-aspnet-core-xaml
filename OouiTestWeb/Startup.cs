namespace ooui_test
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.StaticFiles;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.FileProviders;
    using System.IO;

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
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Set up custom content types - associating file extension to MIME type
            var provider = new FileExtensionContentTypeProvider();
            provider.Mappings[".wasm"] = "application/wasm";
            provider.Mappings[".dll"] = "application/dll";

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            var parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory());
            var newWwwRootDirectory = Path.Combine(parentDirectory.FullName, "OouiTestXamlApp", "bin", "Debug", "netstandard2.0", "dist");


            app.UseDefaultFiles();
            app.UseStaticFiles(new StaticFileOptions{
                ContentTypeProvider = provider,
                 FileProvider = new PhysicalFileProvider(newWwwRootDirectory)
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
