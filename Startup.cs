using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Blog.Models.Entities;
using Blog.Models.Repositories;

namespace Blog
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationCtx>();
            services.AddMvc();
            services.AddTransient<IRepository<Comment>,EfMysqlCommentRepository>();
            services.AddTransient<IRepository<Post>,EfMysqlPostRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePagesWithReExecute("/blog/Errors/Error");
            app.UseStaticFiles();
            app.UseMvc(x =>{
                
                x.MapRoute("post","blog/Post/Entry/{id?}", new {controller="Post", action="Entry"});
                x.MapRoute("default","blog/{controller=Home}/{action=Index}");
            });
        }
    }
}
