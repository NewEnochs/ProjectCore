using System.Collections.Generic;
using System.Text.Json;

namespace Pro.Core.WebApi
{
    public static class DataHdlper
    {


        public static string ToJson(this object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        private static readonly JsonSerializerOptions CamelCaseOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        /// <summary>
        /// 将对象属性名转换为驼峰命名
        /// </summary>
        public static string ConvertToCamelCase(this object obj)
        {
            return JsonSerializer.Serialize(obj, CamelCaseOptions);
        }

        /// <summary>
        /// 将对象转换为驼峰命名的字典
        /// </summary>
        public static Dictionary<string, object> ToCamelCaseDictionary(this object obj)
        {
            var json = JsonSerializer.Serialize(obj, CamelCaseOptions);
            return JsonSerializer.Deserialize<Dictionary<string, object>>(json);
        }
    }
}
