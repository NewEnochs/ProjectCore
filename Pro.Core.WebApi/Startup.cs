using log4net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Pro.Core.DAL;
using Pro.Core.WebApi.Common;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Log4Net.AspNetCore;

namespace Pro.Core.WebApi
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
            services.AddControllers();

            //注册Swagger
            services.AddSwaggerGen(u =>
            {
                u.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "Ver:1.0.0",//版本
                    Title = "学生管理系统",//标题
                    Description = "学生管理系统：包括学生列表、年级管理等。",//描述
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "UserName",
                        Email = "***@hotmail.com"
                    }
                });
            });

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connString = config.GetConnectionString("DefaultConnection");

            // (1) 配置 log4net
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            log4net.Config.XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            // (2) 添加 log4net 到 ILogger
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddLog4Net("log4net.config");
            });

            services.AddControllers();
            services.AddSqlSugar(new IocConfig()
            {
                ConnectionString = connString,
                DbType = IocDbType.SqlServer,
                IsAutoCloseConnection = true
            });

            services.AddIoc(this, "Pro.Core.DAL", it => it.Name.Contains("BaseService"));
            services.AddIoc(this, "Pro.Core.DAL", it => it.Name.Contains("StudentService"));
            //services.AddTransient<IUnitOfWork, SqlSugarUnitOfWork>(); // 注册工作单元到容器
            //注入SqlSugar到API  可以在控制器中使用 ISugarUnitOfWork
            services.AddSqlsugarSetup(Configuration);

            services.AddSingleton<ResultFilter>();
            services.AddMvc(options =>
            {
                options.Filters.Add<ResultFilter>();
            }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);


            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin", policy => policy.SetIsOriginAllowed((host) => true)
                                                                   .AllowAnyHeader()
                                                                   .AllowAnyMethod()
                                                                   .AllowCredentials());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //启用Swagger中间件
            app.UseSwagger();
            //配置SwaggerUI
            app.UseSwaggerUI(u =>
            {
                u.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI_v1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseCors(options =>
            {
                options.WithOrigins("http://localhost:8080", "http://127.0.0.1"); // 允许特定ip跨域
                options.AllowAnyHeader();
                options.AllowAnyMethod();
                options.AllowCredentials();
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
