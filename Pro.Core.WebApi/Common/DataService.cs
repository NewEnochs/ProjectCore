namespace Pro.Core.WebApi
{
    using Microsoft.Extensions.Logging;
    using Pro.Core.DAL;
    using Pro.Core.Model;
    using Pro.Core.WebApi.Controllers;
    using SqlSugar;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public static class DataService
    {
        //private SqlSugarClient chisDb;
        //private readonly ILogger<WeatherForecastController> _logger;

        //public DataService(ILogger<WeatherForecastController> logger)
        //{
        //    chisDb = DbBase.chisDb;
        //    _logger = logger;
        //}

        /// <summary>
        /// 分批查询大数据集
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="pageSize">每批大小</param>
        /// <returns>合并后的数据集</returns>
        public static List<T> GetLargeDataInBatches<T>(SqlSugarClient chisDb, Expression<Func<T, bool>> predicate, Expression<Func<T, T>> expression, int pageSize = 20000) where T : class, new()
        {
            List<T> result = new List<T>();
            int pageIndex = 1;
            int totalCount = 0;

            var query = chisDb.Queryable<T>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (expression != null)
            {
                query = query.Select(expression);
            }

            // 先获取总记录数
            totalCount = query.Count();

            while (true)
            {
                //var batch = query.ToPageList(pageIndex, pageSize);
                var batch = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

                if (batch == null || batch.Count == 0)
                {
                    break;
                }

                result.AddRange(batch);

                // 如果已经获取了所有数据，则退出循环
                if (result.Count >= totalCount)
                {
                    break;
                }

                pageIndex++;

                // 可选：每处理完一批数据后，可以添加短暂的延迟
                // 减轻数据库压力
                System.Threading.Thread.Sleep(100);
            }

            return result;
        }

        /// <summary>
        /// 异步分批查询大数据集
        /// </summary>
        public static async Task<List<T>> GetLargeDataInBatchesAsync<T>(int pageSize = 20000) where T : class, new()
        {
            List<T> result = new List<T>();
            //int pageIndex = 1;
            //int totalCount = 0;

            //// 先获取总记录数
            //totalCount = await chisDb.Queryable<T>().CountAsync();

            //while (true)
            //{
            //    var batch = await chisDb.Queryable<T>()
            //                       .ToPageListAsync(pageIndex, pageSize);

            //    if (batch == null || batch.Count == 0)
            //    {
            //        break;
            //    }

            //    result.AddRange(batch);

            //    if (result.Count >= totalCount)
            //    {
            //        break;
            //    }

            //    pageIndex++;
            //}

            return result;
        }
    }
}
