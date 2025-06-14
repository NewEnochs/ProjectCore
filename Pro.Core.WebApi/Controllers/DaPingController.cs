using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NPOI.POIFS.Properties;
using NPOI.SS.Formula.Functions;
using Pro.Core.Common;
using Pro.Core.DAL;
using Pro.Core.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pro.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaPingController : ControllerBase
    {
        BaseService<Student> stuDal;
        ISugarUnitOfWork<DBContext> Context;
        private SqlSugarClient chisDb;
        private readonly ILogger<WeatherForecastController> _logger;

        public DaPingController(BaseService<Student> _stuDal, ISugarUnitOfWork<DBContext> context, ILogger<WeatherForecastController> logger)
        {
            this.stuDal = _stuDal;
            this.Context = context;
            chisDb = DbBase.chisDb;
            _logger = logger;
        }

        /// <summary>
        /// 获取所有信息
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetList")]
        public dynamic GetList()
        {
            _logger.LogInformation("列表查询开始");
            var dataList = chisDb.Queryable<SYS_BS_MENU>().Where(r => r.NAME.Contains("管理")).ToList();
            var appList = chisDb.Queryable<SYS_BS_APP>().ToList();
            _logger.LogInformation("列表查询结束");
            return new { success = true, data = dataList };
        }


        #region 领导驾驶舱
        /// <summary>
        /// 领导驾驶舱
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost("queryLdjscData")]
        public async Task<dynamic> QueryLdjscData(YZJGDPInput input)
        {
            //input.JGDM = _userManager.OrgInfo.YLJGDM;
            input.YLJGDM = "10000111";
            input.COUNTTYPE = 1;  //1.年报 2.半年报
            input.COUNTLEVEL = 1;   //1.镇级 2.村级
            //最近两年
            var now = DateTime.Now;
            var lastYear = now.AddYears(-1).Year;
            var latestYearList = new List<int>() { now.Year, lastYear };

            //授权机构 超级管理员权限就是所有机构
            var orgList = await chisDb.Queryable<T_JGGL>().Where(r => r.JGBM.StartsWith(input.YLJGDM)).OrderBy(c => c.JGBM).ToListAsync();
            var yljgdmList = orgList.Select(r => r.JGBM).ToList();
            //if (_userManager.SuperAdmin)
            //{
            //    yljgdmList = _userManager.AllYLJGDMList;
            //}
            //else
            //{
            //    yljgdmList = _userManager.YLJGDMList;
            //}

            //基本公卫 领导驾驶舱

            if (input.YEAR == 0)
            {
                input.YEAR = DateTime.Now.Year;
            }

            // 定义参数
            var parameters = new
            {
                JGBM = input.YLJGDM,  // 替换为实际值
                S_TIME = new DateTime(DateTime.Now.Year, 1, 1), // 开始时间
                E_TIME = DateTime.Now  // 结束时间
            };

            string str_sql = string.Format(@"EXEC REPORT_NB_GETALLNB '{0}','{1}','{2}'", parameters.JGBM, parameters.S_TIME, parameters.E_TIME);
            DataTable dt = chisDb.Ado.GetDataTable(str_sql);
            var rtpData = dt.ToList<RPT_JKDAInput>();

            #region 年报查询

            var rtpList = rtpData.GroupBy(d => new { d.JGBM, d.JGMC }).Select(x => new RPT_JKDAInput()
            {
                JGBM = x.Key.JGBM,
                JGMC = x.Key.JGMC,
                JKDA_CZRKS = x.Sum(s => s.JKDA_CZRKS),
                JKDA_JDRS = x.Sum(s => s.JKDA_JDRS),
                JKDA_DZDAS = x.Sum(s => s.JKDA_DZDAS),
                GFHDZDAFGRS = x.Sum(s => s.GFHDZDAFGRS),
                JKDA_DTDAS = x.Sum(s => s.JKDA_DTDAS),
                JKDA_JDRS_RZRS = x.Sum(s => s.JKDA_JDRS_RZRS),
                SFQYFWF = x.Sum(s => s.SFQYFWF),
                JTYSRS = x.Sum(s => s.JTYSRS),
                JTYSQKRS = x.Sum(s => s.JTYSQKRS),
                JTYSZKRS = x.Sum(s => s.JTYSZKRS),
                JTYSTDS = x.Sum(s => s.JTYSTDS),
                JKDA_CZRKS_QYS = x.Sum(s => s.JKDA_CZRKS_QYS),
                JKDA_CZRKS_QYXYS = x.Sum(s => s.JKDA_CZRKS_QYXYS),
                JKDA_ETRS = x.Sum(s => s.JKDA_ETRS),
                JKDA_ETRS_QYRS = x.Sum(s => s.JKDA_ETRS_QYRS),
                JKDA_ETRS_QYXYRS = x.Sum(s => s.JKDA_ETRS_QYXYRS),
                JKDA_JMZS65 = x.Sum(s => s.JKDA_JMZS65),
                JKDA_JMZS65_QYRS = x.Sum(s => s.JKDA_JMZS65_QYRS),
                JKDA_JMZS65_QYXYRS = x.Sum(s => s.JKDA_JMZS65_QYXYRS),
                HCZYJCS = x.Sum(s => s.HCZYJCS),
                HCZYJCS_QYRS = x.Sum(s => s.HCZYJCS_QYRS),
                MB_GXYZGRS = x.Sum(s => s.MB_GXYZGRS),
                MB_GXYQYRS = x.Sum(s => s.MB_GXYQYRS),
                MB_GXYQYXYRS = x.Sum(s => s.MB_GXYQYXYRS),
                MB_TNBZGRS = x.Sum(s => s.MB_TNBZGRS),
                MB_TNBQYRS = x.Sum(s => s.MB_TNBQYRS),
                MB_TNBQYXYRS = x.Sum(s => s.MB_TNBQYXYRS),
                MB_FJHZRS = x.Sum(s => s.MB_FJHZRS),
                MB_FJHQYRS = x.Sum(s => s.MB_FJHQYRS),
                MB_JSBZRS = x.Sum(s => s.MB_JSBZRS),
                MB_JSBQYRS = x.Sum(s => s.MB_JSBQYRS),
                MB_JSBQYXYRS = x.Sum(s => s.MB_JSBQYXYRS),
                JKDA_CJRS = x.Sum(s => s.JKDA_CJRS),
                JKDA_CJQYRS = x.Sum(s => s.JKDA_CJQYRS),
                JKDA_CJQYXYRS = x.Sum(s => s.JKDA_CJQYXYRS),
                JSJT_FQRS = x.Sum(s => s.JSJT_FQRS),
                JSJT_FQQYS = x.Sum(s => s.JSJT_FQQYS),
                JSJT_FQQYXYS = x.Sum(s => s.JSJT_FQQYXYS),
                JKDA_TPRS = x.Sum(s => s.JKDA_TPRS),
                JKDA_TPQYRS = x.Sum(s => s.JKDA_TPQYRS),
                JKDA_TPQYXYRS = x.Sum(s => s.JKDA_TPQYXYRS),
                ZLYS_ZLZL = x.Sum(s => s.ZLYS_ZLZL),
                ZLYS_ZLZL_ZYY = x.Sum(s => s.ZLYS_ZLZL_ZYY),
                ZLYS_ZLSL = x.Sum(s => s.ZLYS_ZLSL),
                ZLYS_ZLSL_ZYY = x.Sum(s => s.ZLYS_ZLSL_ZYY),
                YXZL_ZL = x.Sum(s => s.YXZL_ZL),
                YXZL_ZL_ZYY = x.Sum(s => s.YXZL_ZL_ZYY),
                YXZL_CS = x.Sum(s => s.YXZL_CS),
                YXZL_CS_ZYY = x.Sum(s => s.YXZL_CS_ZYY),
                YXZL_SC = x.Sum(s => s.YXZL_SC),
                XCL_GS = x.Sum(s => s.XCL_GS),
                XCL_GXCS = x.Sum(s => s.XCL_GXCS),
                XCL_GXCS_ZYY = x.Sum(s => s.XCL_GXCS_ZYY),
                JYJZ_JZCS = x.Sum(s => s.JYJZ_JZCS),
                JYJZ_JZCS_ZYY = x.Sum(s => s.JYJZ_JZCS_ZYY),
                JYJZ_JZRS = x.Sum(s => s.JYJZ_JZRS),
                ZXHD_CS = x.Sum(s => s.ZXHD_CS),
                ZXHD_CS_ZYY = x.Sum(s => s.ZXHD_CS_ZYY),
                ZXHD_RS = x.Sum(s => s.ZXHD_RS),
                GXY_RWS = x.Sum(s => s.GXY_RWS),
                GXY_GLRS = x.Sum(s => s.GXY_GLRS),
                GXY_GFGLRS = x.Sum(s => s.GXY_GFGLRS),
                GXY_KZMYRS = x.Sum(s => s.GXY_KZMYRS),
                GXY_JBGFGLRS_FMF = x.Sum(s => s.GXY_JBGFGLRS_FMF),
                SZXYRS = x.Sum(s => s.SZXYRS),
                TNB_RWS = x.Sum(s => s.TNB_RWS),
                TNB_GLRS = x.Sum(s => s.TNB_GLRS),
                TNB_GFGLRS = x.Sum(s => s.TNB_GFGLRS),
                TNB_XTDBRS = x.Sum(s => s.TNB_XTDBRS),
                TNB_JBGFGLRS_FMF = x.Sum(s => s.TNB_JBGFGLRS_FMF),
                TNB_KFXTDBRS = x.Sum(s => s.TNB_KFXTDBRS),
                TNB_KFXTDBRS_MF = x.Sum(s => s.TNB_KFXTDBRS_MF),
                TNB_XTDBRS_MF = x.Sum(s => s.TNB_XTDBRS_MF),
                SZXTRS = x.Sum(s => s.SZXTRS),
                OLDMAN_CZRKS = x.Sum(s => s.OLDMAN_CZRKS),
                OLDMAN_GLRS = x.Sum(s => s.OLDMAN_GLRS),
                OLDMAN_JDRS = x.Sum(s => s.OLDMAN_JDRS),
                OLDMAN_DYTJRS = x.Sum(s => s.OLDMAN_DYTJRS),
                OLDMAN_JKTJS = x.Sum(s => s.OLDMAN_JKTJS),
                OLDMAN_FWRS = x.Sum(s => s.OLDMAN_FWRS),
                FJHZS = x.Sum(s => s.FJHZS),
                FJHGLS = x.Sum(s => s.FJHGLS),
                FJHZS_YZL = x.Sum(s => s.FJHZS_YZL),
                FJHZS_GZFY = x.Sum(s => s.FJHZS_GZFY),
                JSBZS = x.Sum(s => s.JSBZS),
                JSBGFZS = x.Sum(s => s.JSBGFZS),
                JSBZS_JJ = x.Sum(s => s.JSBZS_JJ),
                JSBFYRS = x.Sum(s => s.JSBFYRS),
                JMZS65 = x.Sum(s => s.JMZS65),
                JMZS65_ZYJK = x.Sum(s => s.JMZS65_ZYJK),
                ETZS = x.Sum(s => s.ETZS),
                ETZS_ZYJK = x.Sum(s => s.ETZS_ZYJK),

                // String fields (calculated fields) - these should be calculated after the sums
                JKDAJDL = "", // Will need to be calculated
                DZJKDAJDL = "", // Will need to be calculated
                JMGFHDZDAFGL = "", // Will need to be calculated
                GXYGLL = "", // Will need to be calculated
                GXYGFGLL = "", // Will need to be calculated
                TNBGLL = "", // Will need to be calculated
                GLRQXTBQFKZL = "", // Will need to be calculated
                GLRQXTKZL = "", // Will need to be calculated
                LNRGLL = "", // Will need to be calculated
                LNRGFGLL = "", // Will need to be calculated
                FJHGLL = "", // Will need to be calculated
                FJHHZGZFYL = "", // Will need to be calculated
                YZJSZAGFGLL = "", // Will need to be calculated
                YZJSZAZQJJGLL = "", // Will need to be calculated
                LNRZYYJKGLL = "", // Will need to be calculated
                ETZYYJKGLFWL = "" // Will need to be calculated
            }).ToList();

            foreach (var item in rtpList)
            {
                // Health record rates
                item.JKDAJDL = CalcHelper.CalcRate(item.JKDA_JDRS, item.JKDA_CZRKS, 2, 3, 2);
                item.DZJKDAJDL = CalcHelper.CalcRate(item.JKDA_DZDAS, item.JKDA_CZRKS, 2, 3, 2);
                item.JMGFHDZDAFGL = CalcHelper.CalcRate(item.GFHDZDAFGRS, item.JKDA_CZRKS, 2, 3, 2);

                // Hypertension rates
                item.GXYGLL = CalcHelper.CalcRate(item.GXY_GLRS, item.GXY_RWS, 2, 3, 2);
                item.GXYGFGLL = CalcHelper.CalcRate(item.GXY_GFGLRS, item.GXY_GLRS, 2, 3, 2);

                // Diabetes rates
                item.TNBGLL = CalcHelper.CalcRate(item.TNB_GLRS, item.TNB_RWS, 2, 3, 2);
                item.TNBGFGLL = CalcHelper.CalcRate(item.TNB_GFGLRS, item.TNB_GLRS, 2, 3, 2);

                // Elderly rates
                item.LNRGLL = CalcHelper.CalcRate(item.OLDMAN_GLRS, item.OLDMAN_CZRKS, 2, 3, 2);
                item.LNRGFGLL = CalcHelper.CalcRate(item.OLDMAN_FWRS, item.OLDMAN_CZRKS, 2, 3, 2);

                // Tuberculosis rates
                item.FJHGLL = CalcHelper.CalcRate(item.FJHGLS, item.FJHZS, 2, 3, 2);
                item.FJHHZGZFYL = CalcHelper.CalcRate(item.FJHZS_GZFY, item.FJHZS, 2, 3, 2);

                // Mental illness rates
                item.YZJSZAGFGLL = CalcHelper.CalcRate(item.JSBGFZS, item.JSBZS, 2, 3, 2);
                item.YZJSZAZQJJGLL = CalcHelper.CalcRate(item.JSBZS_JJ, item.JSBZS, 2, 3, 2);

                // Traditional Chinese medicine rates
                item.LNRZYYJKGLL = CalcHelper.CalcRate(item.JMZS65_ZYJK, item.JMZS65, 2, 3, 2);
                item.ETZYYJKGLFWL = CalcHelper.CalcRate(item.ETZS_ZYJK, item.ETZS, 2, 3, 2);
            }

            #region 注释根据表查询的年报 人口平台所用


            //var rtpList = await chisDb.Queryable<RPT_JMJKDAGL>()
            //    .Where(c => c.COUNTTYPE == input.COUNTTYPE)
            //    .Where(c => c.CountLevel == input.COUNTLEVEL)
            //    .Where(c => c.COUNTYEAR == input.YEAR)
            //    .WhereIF(!_userManager.SuperAdmin, d => _userManager.YLJGDMList.Contains(d.JGBM))
            //    .WhereIF(_userManager.SuperAdmin, d => _userManager.AllYLJGDMList.Contains(d.JGBM))
            //    .GroupBy(d => new { d.JGBM, d.JGMC, d.CountLevel })
            //    .Select(x => new RPT_JMJKDAGL
            //    {
            //        JGBM = x.JGBM,
            //        JGMC = x.JGMC,
            //        JKDA_CZRKS = SqlFunc.AggregateSum(x.JKDA_CZRKS),
            //        //JKDA_JDRS = 0m,
            //        JKDA_DZDAS = SqlFunc.AggregateSum(x.JKDA_DZDAS),
            //        GFHDZDAFGRS = SqlFunc.AggregateSum(x.GFHDZDAFGRS),
            //        JKDA_DTDAS = SqlFunc.AggregateSum(x.JKDA_DTDAS),
            //        JKDA_JDRS_RZRS = SqlFunc.AggregateSum(x.JKDA_JDRS_RZRS),
            //        CountLevel = x.CountLevel,
            //    })
            //   .ToListAsync();

            //var rtpList = await chisDb.Queryable<RPT_JTYSQYFW>()
            //    .Where(c => c.COUNTTYPE == input.COUNTTYPE)
            //    .Where(c => c.CountLevel == input.COUNTLEVEL)
            //    .Where(c => c.COUNTYEAR == input.YEAR)
            //    .WhereIF(!_userManager.SuperAdmin, d => _userManager.YLJGDMList.Contains(d.JGBM))
            //    .WhereIF(_userManager.SuperAdmin, d => _userManager.AllYLJGDMList.Contains(d.JGBM))
            //    .ToListAsync();

            //var rtpList = await chisDb.Queryable<RPT_JKJYGLBB>()
            //    .Where(c => c.COUNTTYPE == input.COUNTTYPE)
            //    .Where(c => c.CountLevel == input.COUNTLEVEL)
            //    .Where(c => c.COUNTYEAR == input.YEAR)
            //    .WhereIF(!_userManager.SuperAdmin, d => _userManager.YLJGDMList.Contains(d.JGBM))
            //    .WhereIF(_userManager.SuperAdmin, d => _userManager.AllYLJGDMList.Contains(d.JGBM))
            //    .ToListAsync();

            //// 高血压
            //var rtpList = await chisDb.Queryable<RPT_GXYHZJKGLBB>()
            //    .Where(c => c.COUNTTYPE == input.COUNTTYPE)
            //    .Where(c => c.CountLevel == input.COUNTLEVEL)
            //    .Where(c => c.COUNTYEAR == input.YEAR)
            //    .WhereIF(!_userManager.SuperAdmin, d => _userManager.YLJGDMList.Contains(d.JGBM))
            //    .WhereIF(_userManager.SuperAdmin, d => _userManager.AllYLJGDMList.Contains(d.JGBM))
            //    .ToListAsync();
            //// 糖尿病
            //var rtpList = await chisDb.Queryable<RPT_2XTNBJKGLBB>()
            //    .Where(c => c.COUNTTYPE == input.COUNTTYPE)
            //    .Where(c => c.CountLevel == input.COUNTLEVEL)
            //    .Where(c => c.COUNTYEAR == input.YEAR)
            //    .WhereIF(!_userManager.SuperAdmin, d => _userManager.YLJGDMList.Contains(d.JGBM))
            //    .WhereIF(_userManager.SuperAdmin, d => _userManager.AllYLJGDMList.Contains(d.JGBM))
            //    .ToListAsync();
            //// 肺结核
            //var rtpList = await chisDb.Queryable<RPT_FJHJKGLBB>()
            //    .Where(c => c.COUNTTYPE == input.COUNTTYPE)
            //    .Where(c => c.CountLevel == input.COUNTLEVEL)
            //    .Where(c => c.COUNTYEAR == input.YEAR)
            //    .WhereIF(!_userManager.SuperAdmin, d => _userManager.YLJGDMList.Contains(d.JGBM))
            //    .WhereIF(_userManager.SuperAdmin, d => _userManager.AllYLJGDMList.Contains(d.JGBM))
            //    .ToListAsync();
            //// 严重精神障碍
            //var rtpList = await chisDb.Queryable<RPT_YZJSZAHZGLBB>()
            //    .Where(c => c.COUNTTYPE == input.COUNTTYPE)
            //    .Where(c => c.CountLevel == input.COUNTLEVEL)
            //    .Where(c => c.COUNTYEAR == input.YEAR)
            //    .WhereIF(!_userManager.SuperAdmin, d => _userManager.YLJGDMList.Contains(d.JGBM))
            //    .WhereIF(_userManager.SuperAdmin, d => _userManager.AllYLJGDMList.Contains(d.JGBM))
            //    .ToListAsync();
            //// 老年人
            //var rtpList = await chisDb.Queryable<RPT_LNRJKGLBB>()
            //    .Where(c => c.COUNTTYPE == input.COUNTTYPE)
            //    .Where(c => c.CountLevel == input.COUNTLEVEL)
            //    .Where(c => c.COUNTYEAR == input.YEAR)
            //    .WhereIF(!_userManager.SuperAdmin, d => _userManager.YLJGDMList.Contains(d.JGBM))
            //    .WhereIF(_userManager.SuperAdmin, d => _userManager.AllYLJGDMList.Contains(d.JGBM))
            //    .ToListAsync();
            ////中医药健康监管管理报表
            //var rtpList8 = await chisDb.Queryable<RPT_YYYJKGLBB>()
            //    .Where(c => c.COUNTTYPE == input.COUNTTYPE && c.CountLevel == input.COUNTLEVEL && c.COUNTYEAR == input.YEAR)
            //    .WhereIF(!_userManager.SuperAdmin, d => _userManager.YLJGDMList.Contains(d.JGBM))
            //    .WhereIF(_userManager.SuperAdmin, d => _userManager.AllYLJGDMList.Contains(d.JGBM))
            //    .ToListAsync();
            #endregion

            //#region 汇总
            var sum1 = rtpList.Sum(c => c.JTYSTDS);
            var sum2 = rtpList.Sum(c => c.JTYSRS);
            var sum3 = rtpList.Sum(c => c.JKDA_CZRKS);
            var sum4 = rtpList.Sum(c => c.JKDA_CZRKS_QYS);

            var sumRks = rtpList.Sum(c => c.JKDA_CZRKS);
            var sumDzdas = rtpList.Sum(c => c.JKDA_DZDAS);
            var sumDtfgdas = rtpList.Sum(c => c.GFHDZDAFGRS);
            var sumDtdas = rtpList.Sum(c => c.JKDA_DTDAS);

            var sumRate1 = CalcHelper.CalcRate(sumDzdas, sumRks, 2, 3, 2);
            var sumRate2 = CalcHelper.CalcRate(sumDtfgdas, sumRks, 2, 3, 2);
            var sumRate3 = CalcHelper.CalcRate(sumDtdas, sumDzdas, 2, 3, 2);
            var sumRate4 = CalcHelper.CalcRate(sum4, sum3, 2, 3, 2);
            //#endregion

            #endregion

            #region 档案情况
            var rateList = new List<dynamic>()
            {
                new {title = "建档率", value = sumRate1 },
                new {title = "覆盖率", value = sumRate2 },
                new {title = "使用率", value = sumRate3 },
                new {title = "签约率", value = sumRate4 },
            };
            #endregion

            #region 签约团队结构
            var teamList = new List<dynamic>()
            {
                new {title = "组建团队数", value = sum1 },
                new {title = "家庭医生数", value = sum2 },
            };
            #endregion

            #region 辖区居民情况
            var jgList = await chisDb.Queryable<T_JGGL>().Where(r => r.JGBM.StartsWith(input.YLJGDM)).ToListAsync();
            var dzdas = rtpList.Sum(x => x.JKDA_DZDAS);
            //var qhbm = await db.Queryable<SYS_CONFIG>().Where(a => a.Code == "DPQHBM").Select(a => a.Value).FirstAsync();
            //var qhInfo = await db.Queryable<SYS_TYQHGL>().Where(x => x.PQHBM == qhbm).Select(x => new { x.PQHBM, x.QHBM, x.QHMC }).ToListAsync();
            var mapInfo = new List<dynamic>();
            foreach (var item in jgList)
            {
                var yljgdms = new List<string>() { item.JGBM };
                var dasl = rtpList.Where(x => yljgdms.Contains(x.JGBM)).Sum(x => x.JKDA_DZDAS);
                var gxys = rtpList.Where(x => yljgdms.Contains(x.JGBM)).Sum(x => x.GXY_GLRS);
                var tnbs = rtpList.Where(x => yljgdms.Contains(x.JGBM)).Sum(x => x.TNB_GLRS);
                var fjhs = rtpList.Where(x => yljgdms.Contains(x.JGBM)).Sum(x => x.FJHGLS);
                var yzjszas = rtpList.Where(x => yljgdms.Contains(x.JGBM)).Sum(x => x.JSBGFZS);
                var lnrs = rtpList.Where(x => yljgdms.Contains(x.JGBM)).Sum(x => x.OLDMAN_GLRS);
                var zyyjgsl = rtpList.Where(x => yljgdms.Contains(x.JGBM)).Sum(x => x.JMZS65_ZYJK);  //中医药监管数量
                var gxysfrc = 0;    //高血压随访人次
                var tnbsfrc = 0;    //糖尿病随访人次
                var mapData = new List<dynamic>();
                mapData.Add(dasl);
                mapData.Add(gxys);
                mapData.Add(tnbs);
                mapData.Add(fjhs);
                mapData.Add(yzjszas);
                mapData.Add(lnrs);
                mapData.Add(zyyjgsl);
                mapData.Add(gxysfrc);
                mapData.Add(tnbsfrc);
                var result = new
                {
                    name = item.JGMC,
                    mapData
                };
                mapInfo.Add(result);
            }
            //// 大屏中心点
            //var dpzxd = await db.Queryable<SYS_CONFIG>().Where(a => a.Code == "DPZXD").Select(a => a.Value).FirstAsync();
            //if (string.IsNullOrEmpty(dpzxd))
            //{
            var dpzxd = "0,-10,20";
            //}
            //// 大屏视角距离
            //var dpsjjl = await db.Queryable<SYS_CONFIG>().Where(a => a.Code == "DPSJJL").Select(a => a.Value).FirstAsync();
            //if (string.IsNullOrEmpty(dpsjjl))
            //{
            var dpsjjl = "150";
            //}
            var mapList = new
            {
                mapInfo,
                jgList,
                configInfo = new
                {
                    dpzxd = dpzxd.Split(','),
                    dpsjjl
                }
            };
            #endregion

            #region 签约情况分布
            var qyrs = rtpList.Sum(x => x.JKDA_CZRKS_QYS);
            var xyrs = rtpList.Sum(x => x.JKDA_CZRKS_QYXYS);
            var signList = new List<dynamic>()
            {
                new {name = "签约人数", value = qyrs },
                new {name = "续约人数", value = xyrs },
                new {name = "未签约人数", value = dzdas - qyrs },
            };
            #endregion

            #region 健康教育
            var xclgs = rtpList.Sum(x => x.XCL_GS);
            var bfzl = rtpList.Sum(x => x.YXZL_CS);
            var bfsc = rtpList.Sum(x => x.YXZL_SC);
            var fffs = rtpList.Sum(x => x.ZLYS_ZLSL);
            var ffzl = rtpList.Sum(x => x.ZLYS_ZLZL);
            var jzcs = rtpList.Sum(x => x.JYJZ_JZCS);
            var zxhdcs = rtpList.Sum(x => x.ZXHD_CS);
            var healthList = new
            {
                xclgs,
                bfzl,
                bfsc,
                fffs,
                ffzl,
                jzcs,
                zxhdcs
            };
            #endregion

            #region 签约人群分布
            var ybrq = rtpList.Sum(x => x.JKDA_CZRKS_QYS);
            var pkh = rtpList.Sum(x => x.JKDA_TPQYRS);
            var cjr = rtpList.Sum(x => x.JKDA_CJQYRS);
            var lnr = rtpList.Sum(x => x.JKDA_JMZS65_QYRS);
            var et = rtpList.Sum(x => x.JKDA_ETRS_QYRS);
            var ycf = rtpList.Sum(x => x.HCZYJCS_QYRS);
            var yzjsza = rtpList.Sum(x => x.MB_JSBQYRS);
            var fjh = rtpList.Sum(x => x.MB_FJHQYRS);
            var tnb = rtpList.Sum(x => x.MB_TNBQYRS);
            var gxy = rtpList.Sum(x => x.MB_GXYQYRS);
            var data = new List<decimal>();
            //data.Add(ybrq);
            data.Add(pkh);
            data.Add(cjr);
            data.Add(lnr);
            data.Add(et);
            data.Add(ycf);
            data.Add(yzjsza);
            data.Add(fjh);
            data.Add(tnb);
            data.Add(gxy);
            var maxValue = data.Max();
            var indicator = new List<dynamic>()
                {
                    //new { name = "一般人群", max = maxValue },
                    new { name = "贫困户", max = maxValue },
                    new { name = "残疾人", max = maxValue },
                    new { name = "老年人", max = maxValue },
                    new { name = "儿童", max = maxValue },
                    new { name = "孕产妇", max = maxValue },
                    new { name = "严重精神障碍", max = maxValue },
                    new { name = "肺结核", max = maxValue },
                    new { name = "糖尿病", max = maxValue },
                    new { name = "高血压", max = maxValue },
                };
            var crowdList = new
            {
                data,
                indicator
            };
            #endregion

            #region 年龄 性别分布
            //Expression<Func<T_GRJKDA, T_GRJKDA>> expression = x => new T_GRJKDA()
            //{
            //    CJRQ = x.CJRQ,
            //    XB = x.XB,
            //    AGE = now.Month > x.CSRQ.Value.Month ? now.Year - x.CSRQ.Value.Year : now.Year - x.CSRQ.Value.Year - 1
            //};
            //Expression<Func<T_GRJKDA, bool>> predicate = s => s.ZT == 1 && s.JGBM.StartsWith(input.YLJGDM);
            //var grjkdaList = DataService.GetLargeDataInBatches(chisDb, predicate, expression);


            //个人健康档案
            var query = chisDb.Queryable<T_GRJKDA>().Where(s => s.ZT == 1 && s.JGBM.StartsWith(input.YLJGDM)).Select(x => new BatchInput()
            {
                CJRQ = x.CJRQ,
                XB = x.XB,
                AGE = now.Month > x.CSRQ.Value.Month ? now.Year - x.CSRQ.Value.Year : now.Year - x.CSRQ.Value.Year - 1
            });
            var grjkdaList = query.ToList();

            //List<BatchInput> grjkdaList = new List<BatchInput>();


            //int pageIndex = 1;
            //int pageSize = 15000;
            //int totalCount = query.Count();

            //while (true)
            //{
            //    var batch = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            //    if (batch == null || batch.Count == 0)
            //    {
            //        break;
            //    }

            //    grjkdaList.AddRange(batch);

            //    // 如果已经获取了所有数据，则退出循环
            //    if (grjkdaList.Count >= totalCount)
            //    {
            //        break;
            //    }

            //    pageIndex++;

            //    // 可选：每处理完一批数据后，可以添加短暂的延迟
            //    // 减轻数据库压力
            //    System.Threading.Thread.Sleep(100);
            //}

            //var xbLegend = grjkdaList.GroupBy(c => c.XBMC).Select(r => r.Key).ToList();

            var xbLegend = new List<string>() { "男", "女" };

            List<int> sexData1 = new List<int>();
            var womanData = grjkdaList.Where(c => c.XB == "女").ToList();    //女性
            sexData1.Add(womanData.Where(c => c.AGE < 9).Count());
            sexData1.Add(womanData.Where(c => c.AGE >= 10 && c.AGE <= 19).Count());
            sexData1.Add(womanData.Where(c => c.AGE >= 20 && c.AGE <= 29).Count());
            sexData1.Add(womanData.Where(c => c.AGE >= 30 && c.AGE <= 39).Count());
            sexData1.Add(womanData.Where(c => c.AGE >= 40 && c.AGE <= 49).Count());
            sexData1.Add(womanData.Where(c => c.AGE >= 50 && c.AGE <= 59).Count());
            sexData1.Add(womanData.Where(c => c.AGE >= 60 && c.AGE <= 69).Count());
            sexData1.Add(womanData.Where(c => c.AGE >= 70 && c.AGE <= 79).Count());
            sexData1.Add(womanData.Where(c => c.AGE >= 80 && c.AGE <= 89).Count());
            sexData1.Add(womanData.Where(c => c.AGE >= 90).Count());

            List<int> sexData2 = new List<int>();
            var manData = grjkdaList.Where(c => c.XB == "男").ToList();    //男性
            sexData2.Add(-manData.Where(c => c.AGE < 9).Count());
            sexData2.Add(-manData.Where(c => c.AGE >= 10 && c.AGE <= 19).Count());
            sexData2.Add(-manData.Where(c => c.AGE >= 20 && c.AGE <= 29).Count());
            sexData2.Add(-manData.Where(c => c.AGE >= 30 && c.AGE <= 39).Count());
            sexData2.Add(-manData.Where(c => c.AGE >= 40 && c.AGE <= 49).Count());
            sexData2.Add(-manData.Where(c => c.AGE >= 50 && c.AGE <= 59).Count());
            sexData2.Add(-manData.Where(c => c.AGE >= 60 && c.AGE <= 69).Count());
            sexData2.Add(-manData.Where(c => c.AGE >= 70 && c.AGE <= 79).Count());
            sexData2.Add(-manData.Where(c => c.AGE >= 80 && c.AGE <= 89).Count());
            sexData2.Add(-manData.Where(c => c.AGE >= 90).Count());

            var ageData = new List<string>() { "0-9岁", "10-19岁", "20-29岁", "30-39岁", "40-49岁", "50-59岁", "60-69岁", "70-79岁", "80-89岁", "90岁以上" };
            var sexData = new { sexData1, sexData2, yData = ageData, legend = xbLegend };

            //统计
            ////今年
            //var nowGrkdaData = grjkdaList.Where(c => c.CJRQ.Value.Year == input.YEAR).ToList();
            ////去年
            //var lastGrkdaData = grjkdaList.Where(c => c.CJRQ.Value.Year == lastYear).ToList();

            //var womanNumber = nowGrkdaData.Where(c => c.XB == "2").Count();     //女
            //var manNumver = nowGrkdaData.Where(c => c.XB == "1").Count();       //男

            //var lastWomanNumber = lastGrkdaData.Where(c => c.XB == "2").Count();     //女 去年
            //var lastManNumber = lastGrkdaData.Where(c => c.XB == "1").Count();       //男 去年

            //var xbData = new
            //{
            //    manNumber = manNumver,
            //    yearAdd = manNumver - lastManNumber,
            //    yearRate = CalcHelper.CalcRate(manNumver - lastManNumber, lastManNumber),
            //    womanNumber = womanNumber,
            //    yearWAdd = womanNumber - lastWomanNumber,
            //    yearWRate = CalcHelper.CalcRate(manNumver - lastWomanNumber, lastWomanNumber),
            //};
            #endregion

            #region 管理情况

            List<string> legend = new List<string>();
            List<decimal> gls = new List<decimal>();
            List<string> gll = new List<string>();
            List<string> gfl = new List<string>();

            if (rtpList != null && rtpList.Any())
            {
                var lnrgls = rtpList.Sum(x => x.OLDMAN_GLRS);
                var lnrgll = rtpList.Average(x => decimal.Parse(x.LNRGLL.Replace("%", ""))).ToString("F2");
                var lnrgfl = rtpList.Average(x => decimal.Parse(x.LNRGFGLL.Replace("%", ""))).ToString("F2");
                var jszagls = rtpList.Sum(x => x.JSBGFZS);
                var jszagll = rtpList.Average(x => decimal.Parse(x.YZJSZAZQJJGLL.Replace("%", ""))).ToString("F2");
                var jszagfl = rtpList.Average(x => decimal.Parse(x.YZJSZAGFGLL.Replace("%", ""))).ToString("F2");
                var fjhgls = rtpList.Sum(x => x.FJHGLS);
                var fjhgll = rtpList.Average(x => decimal.Parse(x.FJHGLL.Replace("%", ""))).ToString("F2");
                var fjhgfl = rtpList.Average(x => decimal.Parse(x.FJHHZGZFYL.Replace("%", ""))).ToString("F2");
                var tnbgls = rtpList.Sum(x => x.TNB_GLRS);
                var tnbgll = rtpList.Average(x => decimal.Parse(x.TNBGLL.Replace("%", ""))).ToString("F2");
                var tnbgfl = rtpList.Average(x => decimal.Parse(x.TNBGFGLL.Replace("%", ""))).ToString("F2");
                var gxygls = rtpList.Sum(x => x.GXY_GLRS);
                var gxygll = rtpList.Average(x => decimal.Parse(x.GXYGLL.Replace("%", ""))).ToString("F2");
                var gxygfl = rtpList.Average(x => decimal.Parse(x.GXYGFGLL.Replace("%", ""))).ToString("F2");
                legend = new List<string>() { "高血压", "糖尿病", "肺结核", "严重精神障碍", "老年人" };
                gls = new List<decimal>() { gxygls, tnbgls, fjhgls, jszagls, lnrgls };
                gll = new List<string>() { gxygll, tnbgll, fjhgll, jszagll, lnrgll };
                gfl = new List<string>() { gxygfl, tnbgfl, fjhgfl, jszagfl, lnrgfl };
            }
            var manageList = new
            {
                legend,
                gls,
                gll,
                gfl
            };
            #endregion

            return new
            {
                success = true,
                data = new { sexData, rateList, teamList, dzdas = dzdas.ToString().PadLeft(6, '0'), signList, healthList, crowdList, manageList, mapList },
            };
            //return new { sexData, rateList, teamList, dzdas = dzdas.ToString().PadLeft(6, '0'), signList, healthList, crowdList, manageList, mapList };
        }
        #endregion
    }

    public class BatchInput
    {
        public string XB { get; set; }
        public DateTime? CJRQ { get; set; }
        public int AGE { get; set; }
    }
}