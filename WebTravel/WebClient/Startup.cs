using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebClient.Extentions;

namespace WebClient
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Add sesion
            services.AddDistributedMemoryCache();           // Register Cache Service
            services.AddSession(cfg => {                    // Register Session Service        // Set Name Session - This name used at Browser (Cookie)
                cfg.IdleTimeout = new TimeSpan(0, 5, 0);    // Expire Session
            });

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<IForgetPasswordRepository, ForgetPasswordRepository>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(p =>
                    {
                        p.Cookie.Name = "cse.net.vn";
                        p.LoginPath = "/auth/login";
                        p.AccessDeniedPath = "/auth/denied";
                        p.ExpireTimeSpan = TimeSpan.FromDays(30);
                    })
                    .AddGoogle(options =>
                    {
                        IConfigurationSection googleAuthNSection =
                            Configuration.GetSection("Authentication:Google");
                        options.ClientId = googleAuthNSection["ClientId"];
                        options.ClientSecret = googleAuthNSection["ClientSecret"];
                    })
                    .AddFacebook(facebookOptions => {
                        // Đọc cấu hình
                        IConfigurationSection facebookAuthNSection = Configuration.GetSection("Authentication:Facebook");
                        facebookOptions.AppId = facebookAuthNSection["AppId"];
                        facebookOptions.AppSecret = facebookAuthNSection["AppSecret"];
                        // Thiết lập đường dẫn Facebook chuyển hướng đến
                        facebookOptions.CallbackPath = "/dang-nhap-tu-facebook";
                    });

            var context = new CustomAssemblyLoadContext();
            context.LoadUnmanagedLibrary(Path.Combine(Directory.GetCurrentDirectory(), "libwkhtmltox.dll"));

            services.AddControllers().AddJsonOptions(option => 
            {
                option.JsonSerializerOptions.Converters.Add(new DateConvertor());
            });

            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();
           

            app.UseDeveloperExceptionPage();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                
                endpoints.MapControllerRoute(name: "dashboard", pattern: "{area:exists}/{controller=home}/{action=index}/{id?}");
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
