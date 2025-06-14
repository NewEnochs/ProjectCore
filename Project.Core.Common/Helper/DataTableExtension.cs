using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Core.Common
{
    public static class DataTableExtensions
    {
        /// <summary>
        /// 将 DataTable 转换为 List<T> 泛型集合
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="dt">DataTable 数据源</param>
        /// <returns>转换后的 List<T> 集合</returns>
        public static List<T> ToList<T>(this DataTable dt) where T : new()
        {
            List<T> list = new List<T>();

            if (dt == null || dt.Rows.Count == 0)
            {
                return list;
            }

            // 获取目标类型的属性集合
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (DataRow row in dt.Rows)
            {
                T item = new T();

                foreach (PropertyInfo property in properties)
                {
                    // 检查DataTable中是否有对应的列
                    if (dt.Columns.Contains(property.Name))
                    {
                        // 如果列存在且值不为DBNull，则赋值
                        if (row[property.Name] != DBNull.Value)
                        {
                            // 处理可空类型
                            Type propertyType = property.PropertyType;
                            Type underlyingType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;

                            object value = Convert.ChangeType(row[property.Name], underlyingType);

                            property.SetValue(item, value, null);
                        }
                    }
                }

                list.Add(item);
            }

            return list;
        }
    }
}
