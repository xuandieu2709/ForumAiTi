using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using SignalRChat.Hubs;

namespace ForumAiTi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            ContentRootPath = env.ContentRootPath;
        }

        public IConfiguration Configuration { get; }
        public static string ContentRootPath { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //
            services.AddRazorPages();
            services.AddSignalR();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.LoginPath = "/login";
                        options.Cookie.Name = "forumAiTi_auth_cookie";
                        options.AccessDeniedPath = "/login";
                    })
                    .AddGoogle(GoogleDefaults.AuthenticationScheme, googleOptions =>
                {
                    // Thiết lập ClientID và ClientSecret để truy cập API google
                    googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                    googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
                    googleOptions.ClaimActions.MapJsonKey("urn:google:picture", "picture", "url");
                    // Cấu hình Url callback lại từ Google (không thiết lập thì mặc định là /signin-google)
                    googleOptions.CallbackPath = "/login-google";
                }).AddFacebook(facebookOptions =>
                {
                    // Đọc cấu hình
                    IConfigurationSection facebookAuthNSection = Configuration.GetSection("Authentication:Facebook");
                    facebookOptions.AppId = facebookAuthNSection["AppId"];
                    facebookOptions.AppSecret = facebookAuthNSection["AppSecret"];
                    // Thiết lập đường dẫn Facebook chuyển hướng đến
                    facebookOptions.CallbackPath = "/login-facebook";
                });
            // services.AddAuthentication(options =>
            // {
            //     options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //     options.DefaultAuthenticateScheme = GoogleDefaults.AuthenticationScheme;
            // })


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // app.UseExceptionHandler("/Error/{0}");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseExceptionHandler("/Error/500");   
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id?}");
                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
