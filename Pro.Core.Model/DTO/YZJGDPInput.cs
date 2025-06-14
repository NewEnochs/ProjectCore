using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Core.Model
{
    /// <summary>
    /// 院长监管大屏参数
    /// </summary>
    public class YZJGDPInput
    {
        /// <summary>
        /// 机构代码
        /// </summary>
        public string JGDM { get; set; }

        /// <summary>
        /// 开始时间 前端选择本月 本季 本年 时间赋值
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 结束时间 前端选择本月 本季 本年 时间赋值
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 年报 年份
        /// </summary>
        public int YEAR { get; set; }

        /// <summary>
        /// 年报类型 1.年报 2.半年报
        /// </summary>
        public int COUNTTYPE { get; set; }

        /// <summary>
        /// 统计等级(1镇级 2 村级)  
        /// </summary>
        public int COUNTLEVEL { get; set; }

        /// <summary>
        /// 查询类型 1.公卫 2.医疗
        /// </summary>
        public int SearchType { get; set; }

        //本周 本月 本季 本年
        public string DateType { get; set; }

        /// <summary>
        /// 预警指标
        /// </summary>
        public List<string> TXTYPELIST { get; set; }

        public string YLJGDM { get; set; }

    }
}
