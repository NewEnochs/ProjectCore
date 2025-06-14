using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Core.Common
{
    public static class CalcHelper
    {
        #region 计算利率方法和计算图标 两个方法
        /// <summary>
        /// 计算利率
        /// </summary>
        /// <param name="count">占有（今年） 被除数</param>
        /// <param name="total">总数（去年）除数</param>
        /// <param name="type">type 1 加百分号 2.不加百分号 前端加 3不加百分号 再除以100 保留4位小数及以上 </param>
        /// <param name="level">level 0 不做处理 用于增长率  3数据为0的处理 处理为0 </param>
        /// <param name="xs">xs 保留小数位数 默认保留2位小数</param>
        /// <param name="isColor">isColor 是否返回颜色 院长大屏管理需要</param>
        /// <returns></returns>
        public static string CalcRate(decimal count, decimal total, int type = 1, int level = 0, int xs = 2, bool isColor = false)
        {
            var rate = "0";
            var fh = "%";
            if (type == 2 || type == 3) { fh = ""; }
            if (count == 0 && total > 0)
            {
                if (level == 3)
                {
                    rate = "0";
                }
                else
                {
                    rate = "-100";
                }
            }
            if (count > 0 && total == 0)
            {
                if (level == 3)
                {
                    rate = "0";
                }
                else
                {
                    rate = "100";
                }
            }
            if (count == 0 && total == 0)
            {
                rate = "0";
            }
            else if (count == total)
            {
                rate = "100";
            }

            var suffix = "";
            for (int i = 0; i < xs; i++)
            {
                suffix += "0";
            }
            if (!string.IsNullOrEmpty(suffix))
            {
                suffix = "." + suffix;
            }

            if (count != 0 && total != 0 && count != total)
            {
                rate = (Math.Round(count / total * 10000, 4) / 100).ToString("f" + xs);
                //if (type == 3)      //不需要百分号 再除以100 
                //{
                //    rate = (rate.ToDecimal() / 100m).ToString();
                //    if (rate.ToDecimal() < 0.01m)
                //    {
                //        return rate.ToDecimal().ToString("f4");
                //    }
                //}
                if (isColor)
                {
                    if (rate.ToDecimal() > 90)
                    {
                        return "#24971D";
                    }
                    else
                    {
                        return "#24971D";
                    }
                }
                return (rate.IndexOf(".") > 0 && rate.EndsWith(".0") == false
                    ? (rate.Substring(rate.IndexOf(".") + 1).Length >= xs ? rate.Substring(0, rate.IndexOf(".") + xs + 1) : rate)
                    : (rate.EndsWith(".0") == false ? rate + suffix + fh : rate.Replace(".0", "") + suffix)) + fh;
            }
            if (isColor)
            {
                if (rate.ToDecimal() > 90)
                {
                    return "#24971D";
                }
                else
                {
                    return "#24971D";
                }
            }

            return rate + suffix + fh;
        }

        /// <summary>
        /// 图标
        /// </summary>
        /// <param name="num1">今年</param>
        /// <param name="num2">去年</param>
        /// <returns></returns>
        public static string CalcIcon(decimal num1, decimal num2)
        {
            if (num1 > num2)
            {
                return "arrow-up";
            }
            else if (num1 < num2)
            {
                return "arrow-down";
            }
            else { return ""; }
        }

        #endregion


        #region 计算环比/同比  
        /// <summary>
        /// 计算环比/同比 
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="total">总量</param>
        /// <param name="lastTotal">同比/环比 去年/上个月数量</param>
        /// <returns></returns>
        public static TBHBData CalcTbHbData(string title, decimal total, decimal lastTotal)
        {
            TBHBData data = new TBHBData();
            data.Rate = CalcHelper.CalcRate(total - lastTotal, lastTotal, 1, 3);     //环比收入 增长率
            //图标以及颜色
            data.IconColor = "black";
            data.Icon = "=";
            if (total < lastTotal)
            {
                data.IconColor = "red";
                data.Icon = "arrow-down";
            }
            else if (total > lastTotal)
            {
                data.IconColor = "green";
                data.Icon = "arrow-up";
            }
            return data;
        }

        #endregion
    }


    public class TBHBData
    {
        /// <summary>
        /// 增长率
        /// </summary>
        public string Rate { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 图标颜色
        /// </summary>
        public string IconColor { get; set; }

    }
}
