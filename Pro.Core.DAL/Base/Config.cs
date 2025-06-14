using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pro.Core.DAL
{
    public class Config
    {
        /// <summary>
        /// Account have permission to create database
        /// 用有建库权限的数据库账号
        /// </summary>
        public static string ConnectionString = GetConnString();

        public static string CHIS = GetConnString("CHIS");
        /// <summary>
        /// Account have permission to create database
        /// 用有建库权限的数据库账号
        /// </summary>
        //public static string ConnectionString2 = "server=.;uid=sa;pwd=sasa;database=SQLSUGAR4XTEST2";
        /// <summary>
        /// Account have permission to create database
        /// 用有建库权限的数据库账号
        /// </summary>
        //public static string ConnectionString3 = "server=.;uid=sa;pwd=sasa;database=SQLSUGAR4XTEST3";


        ///获取配置的连接字符串
        public static string GetConnString(string connName= "DefaultConnection")
        {
            //获取链接字符串
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connString = config.GetConnectionString(connName);
            return connString;
        }

    }
}
