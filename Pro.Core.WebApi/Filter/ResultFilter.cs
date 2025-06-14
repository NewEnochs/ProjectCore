using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Pro.Core.WebApi
{
    /// <summary>
    /// 返回拦截
    /// </summary>
    public class ResultFilter : IResultFilter
    {
        /// <summary>
        /// 在操作结果执行之后调用
        /// </summary>
        /// <param name="context"></param>
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

        /// <summary>
        /// 在操作结果执行之前调用
        /// </summary>
        /// <param name="context"></param>
        public void OnResultExecuting(ResultExecutingContext context)
        {
            string ActionName = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ActionName;
            string ControllerName = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)context.ActionDescriptor).ControllerName;

            string IV = "";
            // 在OnResultExecuting中取出保存好的参数值
            if (context.HttpContext.Items.ContainsKey("IV"))
            {
                IV = context.HttpContext.Items["IV"].ToString();
            }

            var h = context.Result as ObjectResult;
            if (h == null)
            {
                return;
            }

            var r = h?.Value;
            string jsonstr;
            try
            {
                jsonstr = r.ConvertToCamelCase().ToJson();
            }
            catch
            {
                jsonstr = r.ToString();
            }


            //DateTime dt_end = DateTime.Now;
            //TimeSpan ts1 = new TimeSpan(dt_begin.Ticks);
            //TimeSpan ts2 = new TimeSpan(dt_end.Ticks);
            //TimeSpan ts3 = ts1.Subtract(ts2).Duration();
            //string datediff_sec = ts3.TotalSeconds.ToString();

            //System.Diagnostics.Debug.WriteLine(string.Format("---------------加密 执行开始时间=>>{0}", dt_begin));
            //System.Diagnostics.Debug.WriteLine(string.Format("---------------加密 执行结束时间=>>{0}", dt_end));
            //System.Diagnostics.Debug.WriteLine(string.Format("---------------加密 耗时=>>        {0}秒", datediff_sec));

            context.Result = new ContentResult()
            {
                StatusCode = (int)HttpStatusCode.OK,
                ContentType = "application/json;charset=utf-8",
                Content = jsonstr,
            };

        }


    }
}