using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MovieApp.Web
{
    public class Startup
    {
        // Bu yöntem, çalışma zamanı tarafından çağrılır. Bu yöntemi, hizmetleri konteynıra eklemek için kullanın. 
        // Uygulamanızı nasıl yapılandıracağınız hakkında daha fazla bilgi için şu adresi ziyaret edin: https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();            //  MVC'yi uygulamaya ekler.
        }

        // Bu yöntem, çalışma zamanı tarafından çağrılır. Bu yöntemi, HTTP istek boru hattını yapılandırmak için kullanın.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
