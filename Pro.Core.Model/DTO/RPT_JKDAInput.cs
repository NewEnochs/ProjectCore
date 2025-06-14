using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Core.Model
{
    public class RPT_JKDAInput
    {
        public string JGBM { get; set; }

        public string JGMC { get;set; }

        /// <summary>
        /// 常住人口数
        /// </summary>
        public int JKDA_CZRKS { get; set; }

        /// <summary>
        /// 建档人数
        /// </summary>
        public int JKDA_JDRS { get; set; }

        /// <summary>
        /// 建立电子健康档案人数
        /// </summary>
        public int JKDA_DZDAS { get; set; }

        /// <summary>
        /// 居民规范化电子健康档案覆盖人数（人）
        /// </summary>
        public int GFHDZDAFGRS { get; set; }

        /// <summary>
        /// 档案中有动态记录的档案份数
        /// </summary>
        public int JKDA_DTDAS { get; set; }

        /// <summary>
        /// 认证档案数
        /// </summary>
        public int JKDA_JDRS_RZRS { get; set; }

        /// <summary>
        /// 健康档案建档率 JKDA_JDRS/JKDA_CZRKS
        /// </summary>
        public string JKDAJDL { get; set; }


        /// <summary>
        /// 电子健康档案建档率 JKDA_DZDAS/JKDA_CZRKS
        /// </summary>
        public string DZJKDAJDL { get; set; }

        /// <summary>
        /// 居民规范化电子健康的档案覆盖率 GFHDZDAFGRS/JKDA_CZRKS
        /// </summary>
        public string JMGFHDZDAFGL { get; set; }

        //=================================================================================================家庭签约

        /// <summary>
        /// 是否有签约服务费 0无 1有
        /// </summary>
        public int SFQYFWF { get; set; }

        /// <summary>
        /// 2.1家庭医生人数（人）
        /// </summary>
        public int JTYSRS { get; set; }

        /// <summary>
        /// 2.2家庭医生团队中全科医生人数（人）
        /// </summary>
        public int JTYSQKRS { get; set; }

        /// <summary>
        ///  2.3家庭医生团队中专科医生人数（人）
        /// </summary>
        public int JTYSZKRS { get; set; }

        /// <summary>
        /// 2.4已组建家庭医生团队数（个）
        /// </summary>
        public int JTYSTDS { get; set; }

        /// <summary>
        ///2.5 常住人口签约数（人）
        /// </summary>
        public int JKDA_CZRKS_QYS { get; set; }

        /// <summary>
        /// 2.6 常住人口签约续约数（人）:
        /// </summary>
        public int JKDA_CZRKS_QYXYS { get; set; }

        /// <summary>
        /// 辖区内0-6岁儿童数（人）
        /// </summary>
        public int JKDA_ETRS { get; set; }

        /// <summary>
        ///  0-6岁儿童签约数（人）
        /// </summary>
        public int JKDA_ETRS_QYRS { get; set; }

        /// <summary>
        /// 0-6岁儿童签约续约数（人）
        /// </summary>
        public int JKDA_ETRS_QYXYRS { get; set; }

        /// <summary>
        /// 辖区内65岁及以上常住居民数（人）
        /// </summary>
        public int JKDA_JMZS65 { get; set; }

        /// <summary>
        /// 65岁及以上常住居民签约数（人）
        /// </summary>
        public int JKDA_JMZS65_QYRS { get; set; }

        /// <summary>
        /// 65岁及以上常住居民签约续约数（人）
        /// </summary>
        public int JKDA_JMZS65_QYXYRS { get; set; }

        /// <summary>
        /// 辖区内孕13周之前建册并进行第一次产前检查的产妇人数（人） 
        /// </summary>
        public int HCZYJCS { get; set; }

        /// <summary>
        /// 孕产妇签约数（人）
        /// </summary>
        public int HCZYJCS_QYRS { get; set; }

        /// <summary>
        /// 年内辖区内已管理的高血压患者人数（人）
        /// </summary>
        public int MB_GXYZGRS { get; set; }

        /// <summary>
        /// 在管高血压患者家庭医生签约人数（人）
        /// </summary>
        public int MB_GXYQYRS { get; set; }

        /// <summary>
        /// 在管高血压患者签约续约数（人）
        /// </summary>
        public int MB_GXYQYXYRS { get; set; }


        /// <summary>
        /// 年内辖区内已管理的2型糖尿病患者人数（人）
        /// </summary>
        public int MB_TNBZGRS { get; set; }

        /// <summary>
        /// 糖尿病患者签约数（人）
        /// </summary>
        public int MB_TNBQYRS { get; set; }

        /// <summary>
        /// 糖尿病患者签约续约数（人）
        /// </summary>
        public int MB_TNBQYXYRS { get; set; }

        /// <summary>
        /// 已管理的肺结核患者人数（人）
        /// </summary>
        public int MB_FJHZRS { get; set; }

        /// <summary>
        /// 肺结核患者签约数（人）
        /// </summary>
        public int MB_FJHQYRS { get; set; }

        /// <summary>
        ///  辖区内登记在册、诊断明确、在家居住的严重精神障碍患者人数（人）
        /// </summary>
        public int MB_JSBZRS { get; set; }

        /// <summary>
        ///  严重精神障碍患者签约数（人）
        /// </summary>
        public int MB_JSBQYRS { get; set; }

        /// <summary>
        /// 严重精神障碍患者签约续约数（人）
        /// </summary>
        public int MB_JSBQYXYRS { get; set; }

        /// <summary>
        /// 辖区内残疾人数（人）
        /// </summary>
        public int JKDA_CJRS { get; set; }

        /// <summary>
        ///  残疾人签约数（人）
        /// </summary>
        public int JKDA_CJQYRS { get; set; }

        /// <summary>
        /// 残疾人签约续约数（人）
        /// </summary>
        public int JKDA_CJQYXYRS { get; set; }

        /// <summary>
        /// 纳入计划生育家庭特别扶助制度的独生子女伤残或死亡家庭的夫妻人数（人）
        /// </summary>
        public int JSJT_FQRS { get; set; }

        /// <summary>
        /// 纳入计划生育家庭特别扶助制度的独生子女伤残或死亡家庭的夫妻签约数（人）
        /// </summary>
        public int JSJT_FQQYS { get; set; }

        /// <summary>
        /// 纳入计划生育家庭特别扶助制度的独生子女伤残或死亡家庭的夫妻签约续约数（人）
        /// </summary>
        public int JSJT_FQQYXYS { get; set; }

        /// <summary>
        /// 辖区内脱贫人口数（人）
        /// </summary>
        public int JKDA_TPRS { get; set; }

        /// <summary>
        /// 脱贫人口签约数（人）
        /// </summary>
        public int JKDA_TPQYRS { get; set; }

        /// <summary>
        /// 脱贫人口签约续约数（人）
        /// </summary>
        public int JKDA_TPQYXYRS { get; set; }


        //=================================================================================================健康教育

        /// <summary>
        /// 发放健康教育印刷资料种类（种）
        /// </summary>
        public int ZLYS_ZLZL { get; set; }
        /// <summary>
        /// 中医药印刷资料种类（种）
        /// </summary>
        public int ZLYS_ZLZL_ZYY { get; set; }

        /// <summary>
        /// 发放健康教育印刷资料数量（本）
        /// </summary>
        public int ZLYS_ZLSL { get; set; }

        /// <summary>
        /// 中医药印刷资料数量（本）
        /// </summary>
        public int ZLYS_ZLSL_ZYY { get; set; }

        /// <summary>
        /// 播放健康教育音像资料种类（种）
        /// </summary>
        public int YXZL_ZL { get; set; }

        /// <summary>
        /// 播放中医药音像资料种类（种）
        /// </summary>
        public int YXZL_ZL_ZYY { get; set; }

        /// <summary>
        /// 播放健康教育音像资料次数（次）
        /// </summary>
        public int YXZL_CS { get; set; }

        /// <summary>
        /// 播放中医药音像资料次数（次）
        /// </summary>
        public int YXZL_CS_ZYY { get; set; }

        /// <summary>
        /// 播放健康教育音像资料的时间（小时）
        /// </summary>
        public int YXZL_SC { get; set; }

        /// <summary>
        /// 健康教育宣传栏设置个数（个）
        /// </summary>
        public int XCL_GS { get; set; }

        /// <summary>
        /// 健康教育宣传栏内容更新次数（次）
        /// </summary>
        public int XCL_GXCS { get; set; }

        /// <summary>
        /// 中医药内容更新次数（次）
        /// </summary>
        public int XCL_GXCS_ZYY { get; set; }

        /// <summary>
        /// 举办健康教育讲座次数（次）
        /// </summary>
        public int JYJZ_JZCS { get; set; }

        /// <summary>
        /// 包含中医药内容的健康教育讲座次数（次）
        /// </summary>
        public int JYJZ_JZCS_ZYY { get; set; }

        /// <summary>
        /// 健康教育讲座参加人数（人）
        /// </summary>
        public int JYJZ_JZRS { get; set; }

        /// <summary>
        /// 健康教育咨询活动次数（次）
        /// </summary>
        public int ZXHD_CS { get; set; }

        /// <summary>
        /// 包含中医药内容的健康教育咨询活动次数（次）
        /// </summary>
        public int ZXHD_CS_ZYY { get; set; }

        /// <summary>
        /// 健康教育咨询活动人数（人）
        /// </summary>
        public int ZXHD_RS { get; set; }

        //=================================================================================================高血压

        /// <summary>
        /// 辖区内应管理人数
        /// </summary>
        public int GXY_RWS { get; set; }

        /// <summary>
        /// 已管理高血压患者人数
        /// </summary>
        public int GXY_GLRS { get; set; }

        /// <summary>
        /// 按照规范要求提供高血压患者健康管理服务的人数
        /// </summary>
        public int GXY_GFGLRS { get; set; }

        /// <summary>
        /// 最近一次随访血压达标人数
        /// </summary>
        public int GXY_KZMYRS { get; set; }

        /// <summary>
        /// 按规范要求进行高血压患者健康管理的人数（不区分随访方式）（人）
        /// </summary>
        public int GXY_JBGFGLRS_FMF { get; set; }

        /// <summary>
        /// 首诊测血压人数
        /// </summary>
        public int SZXYRS { get; set; }

        /// <summary>
        /// 高血压患者基层规范管理服务率 GXY_GFGLRS/GXY_GLRS
        /// </summary>
        public string GXYGLL { get; set; }

        /// <summary>
        /// 高血压规范管理率 GXY_GFGLRS/GXY_GLRS
        /// </summary>
        public string GXYGFGLL { get; set; }

        //=================================================================================================糖尿病

        /// <summary>
        /// 辖区内糖尿病患者应管理人数
        /// </summary>
        public int TNB_RWS { get; set; }

        /// <summary>
        /// 辖区内糖尿病患者已经管理人数
        /// </summary>
        public int TNB_GLRS { get; set; }

        /// <summary>
        /// 在基层医疗卫生机构按照规范要求提供2型糖尿病患者健康管理服务的人数（人）
        /// </summary>
        public int TNB_GFGLRS { get; set; }


        /// <summary>
        /// 2型糖尿病管理率（%） TNB_GLRS/TNB_GLRS
        /// </summary>
        public string TNBGLL { get; set; }

        /// <summary>
        /// 2型糖尿病患者基层规范管务率（%） TNB_GFGLRS/TNB_GLRS
        /// </summary>
        public string TNBGFGLL { get; set; }

        /// <summary>
        /// 最近一次随访血糖达标人数 (不区分检测类 型、随访方式)
        /// </summary>
        public int TNB_XTDBRS { get; set; }

        /// <summary>
        /// 管理人群血糖控制率(不区分检 测类型、随访 方式)（%） TNB_XTDBRS/TNB_GLRS
        /// </summary>
        public string GLRQXTBQFKZL { get; set; }

        /// <summary>
        /// 按规范要求进行2型糖尿病患者健康管理的人数（不区 分随访方式）（人）
        /// </summary>
        public int TNB_JBGFGLRS_FMF { get; set; }

        /// <summary>
        /// 最近一次随访空腹血糖达标人数(不区分随访方式)
        /// </summary>
        public int TNB_KFXTDBRS { get; set; }

        /// <summary>
        /// 管理人群血糖控制率（%） TNB_KFXTDBRS/TNB_GLRS
        /// </summary>
        public string GLRQXTKZL { get; set; }

        /// <summary>
        /// 最近一次面访空腹血糖达标人数
        /// </summary>
        public int TNB_KFXTDBRS_MF { get; set; }

        /// <summary>
        /// 最近一次面访血糖达标人数 (不区分检测类型)
        /// </summary>
        public int TNB_XTDBRS_MF { get; set; }

        /// <summary>
        /// 首诊测血糖人数
        /// </summary>
        public int SZXTRS { get; set; }

        //=================================================================================================老年人

        /// <summary>
        /// 老年人常驻居民数
        /// </summary>
        public int OLDMAN_CZRKS { get; set; }

        /// <summary>
        /// 接收健康管理人数
        /// </summary>
        public int OLDMAN_GLRS { get; set; }
        /// <summary>
        /// 老年人健康管理率 OLDMAN_GLRS/OLDMAN_CZRKS
        /// </summary>
        public string LNRGLL { get; set; }

        /// <summary>
        /// 建立健康档案的65岁及以上老年人人数
        /// </summary>
        public int OLDMAN_JDRS { get; set; }

        /// <summary>
        /// 当月完成的65岁及以上老年人健康体检人数
        /// </summary>
        public int OLDMAN_DYTJRS { get; set; }

        /// <summary>
        /// 65岁及以上老年人健康体检人数（人）
        /// </summary>
        public int OLDMAN_JKTJS { get; set; }

        /// <summary>
        /// 65岁及以上老年人城乡社区规范健康管理服务人数（人）
        /// </summary>
        public int OLDMAN_FWRS { get; set; }

        /// <summary>
        /// 65岁及以上老年人城乡社区规范健康管理服务率（%） OLDMAN_FWRS/OLDMAN_CZRKS
        /// </summary>
        public string LNRGFGLL { get; set; }

        //=================================================================================================肺结核

        /// <summary>
        ///  辖区同期内经上级定点医疗机构确诊并通知基层医疗卫生机构管理的肺结核患者人数(人)
        /// </summary>
        public int FJHZS { get; set; }

        /// <summary>
        /// 已管理的肺结核患者人数(人)
        /// </summary>
        public int FJHGLS { get; set; }

        /// <summary>
        /// 同期辖区内已完成治疗的肺结核患者人数(人)
        /// </summary>
        public int FJHZS_YZL { get; set; }

        /// <summary>
        /// 按照要求规则服药的肺结核患者人数(人)
        /// </summary>
        public int FJHZS_GZFY { get; set; }

        /// <summary>
        /// 肺结核患者管理率  FJHGLS/FJHZS
        /// </summary>
        public string FJHGLL { get; set; }

        /// <summary>
        /// 肺结核患者规则管理率 FJHZS_GZFY/FJHZS
        /// </summary>
        public string FJHHZGZFYL { get; set; }

        //=================================================================================================严重精神障碍

        /// <summary>
        /// 辖区内登记在册的确诊严重精神障碍患者人数(人)
        /// </summary>
        public int JSBZS { get; set; }

        /// <summary>
        /// 辖区内按照规范要求进行管理的严重精神障碍患者人数(人)	
        /// </summary>
        public int JSBGFZS { get; set; }

        /// <summary>
        /// 社区在册居家严重精神障碍患者健康管理人数(人)
        /// </summary>
        public int JSBZS_JJ { get; set; }

        /// <summary>
        /// 服药人数
        /// </summary>
        public int JSBFYRS { get; set; }

        /// <summary>
        /// 严重精神障碍患者规范管理率 JSBGFZS/JSBZS
        /// </summary>
        public string YZJSZAGFGLL { get; set; }

        /// <summary>
        /// 社区在册居家严重精神障碍患者健康管理率 JSBZS_JJ/JSBZS
        /// </summary>
        public string YZJSZAZQJJGLL { get; set; }

        //=================================================================================================中医药健康管理

        /// <summary>
        /// 辖区内65岁及以上常住居民数（人）
        /// </summary>
        public int JMZS65 { get; set; }

        /// <summary>
        /// 接受中医药健康管理服务65岁及以上居民数（人）
        /// </summary>
        public int JMZS65_ZYJK { get; set; }

        /// <summary>
        ///  辖区内应管理的0-36个月儿童数（人）
        /// </summary>
        public int ETZS { get; set; }

        /// <summary>
        ///  辖区内按照月龄接受中医药健康管理服务的0-36个月儿童数（人）
        /// </summary>
        public int ETZS_ZYJK { get; set; }

        /// <summary>
        /// 老年人中医药健康管理率 JMZS65_ZYJK/JMZS65
        /// </summary>
        public string LNRZYYJKGLL { get; set; }

        /// <summary>
        /// 0-36月儿童中医药健康管理服务率 ETZS_ZYJK/ETZS
        /// </summary>
        public string ETZYYJKGLFWL { get; set; }
        
    }
}
