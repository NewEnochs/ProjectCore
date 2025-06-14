using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pro.Core.Model;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.IO;

namespace Pro.Core.DAL
{
    public static class DbBase
    {
        #region 数据库连接配置
        public static SqlSugarClient CreateDbConnection()
        {
            //    SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            //    {
            //        ConnectionString = Config.ConnectionString,//连接符字串
            //        DbType = DbType.SqlServer,
            //        IsAutoCloseConnection = true //不设成true要手动close
            //    });

            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                DbType = DbType.SqlServer,
                ConnectionString = Config.ConnectionString,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true,
                AopEvents = new AopEvents
                {
                    OnLogExecuting = (sql, p) =>
                    {
                        Console.WriteLine(sql);
                    }
                }
            });

            return db;
        }
        #endregion

        public static SqlSugarClient Db => CreateDbConnection();

        #region 数据库连接配置
        public static SqlSugarClient CreatChisbConnection()
        {
            //    SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            //    {
            //        ConnectionString = Config.ConnectionString,//连接符字串
            //        DbType = DbType.SqlServer,
            //        IsAutoCloseConnection = true //不设成true要手动close
            //    });

            SqlSugarClient chisDb = new SqlSugarClient(new ConnectionConfig()
            {
                DbType = DbType.SqlServer,
                ConnectionString = Config.CHIS,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true,
                AopEvents = new AopEvents
                {
                    OnLogExecuting = (sql, p) =>
                    {
                        Console.WriteLine(sql);
                    }
                }
            });

            return chisDb;
        }
        #endregion

        public static SqlSugarClient chisDb => CreatChisbConnection();

    }


    //创建一个注入类
    public static class SqlsugarSetup
    {
        public static void AddSqlsugarSetup(this IServiceCollection services, IConfiguration configuration)
        {
            //多租户 new SqlSugarScope(List<ConnectionConfig>,db=>{});

            SqlSugarScope sqlSugar = new SqlSugarScope(new ConnectionConfig()
            {
                DbType = SqlSugar.DbType.SqlServer,
                ConnectionString = Config.ConnectionString,
                IsAutoCloseConnection = true,
            },
             db => {  /***写AOP等方法***/});
            ISugarUnitOfWork<DBContext> context = new SugarUnitOfWork<DBContext>(sqlSugar);
            services.AddSingleton<ISugarUnitOfWork<DBContext>>(context);
        }
    }
}
