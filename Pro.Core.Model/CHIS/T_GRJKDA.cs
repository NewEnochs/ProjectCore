
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;
using SystemData = System.Data;

namespace Pro.Core.Model
{
    /// <summary> 
    /// 居民健康档案 
    /// </summary>
    [SugarTable("T_GRJKDA", "居民健康档案")]
    public class T_GRJKDA
    {
        /// <summary>
        /// id 
        /// </summary>
        [SugarColumn(ColumnName = "ID", IsIdentity = true)]
        public int ID { get; set; }
        /// <summary>
        /// 健康档案号 
        /// </summary>
        [SugarColumn(ColumnName = "DAH", IsPrimaryKey = true, SqlParameterDbType = SystemData.DbType.AnsiString, SqlParameterSize = 20)]
        public string DAH { get; set; }
        /// <summary>
        /// 姓名 
        /// </summary>
        [SugarColumn(ColumnName = "XM")]
        public string XM { get; set; }
        /// <summary>
        /// 拼音代码 
        /// </summary>
        [SugarColumn(ColumnName = "PYDM")]
        public string PYDM { get; set; }
        /// <summary>
        /// 五笔代码 
        /// </summary>
        [SugarColumn(ColumnName = "WBDM")]
        public string WBDM { get; set; }
        /// <summary>
        /// 现住址 
        /// </summary>
        [SugarColumn(ColumnName = "XZZ")]
        public string XZZ { get; set; }
        /// <summary>
        /// 户籍地址 
        /// </summary>
        [SugarColumn(ColumnName = "HJDZ")]
        public string HJDZ { get; set; }
        /// <summary>
        /// 联系电话 
        /// </summary>
        [SugarColumn(ColumnName = "LXDH")]
        public string LXDH { get; set; }
        /// <summary>
        /// 乡镇(街道)名称 
        /// </summary>
        [SugarColumn(ColumnName = "XZJDMC")]
        public string XZJDMC { get; set; }
        /// <summary>
        /// 村(居)委会名称 
        /// </summary>
        [SugarColumn(ColumnName = "CJWHMC")]
        public string CJWHMC { get; set; }
        /// <summary>
        /// 建档单位 
        /// </summary>
        [SugarColumn(ColumnName = "JDDW")]
        public string JDDW { get; set; }
        /// <summary>
        /// 建档人 
        /// </summary>
        [SugarColumn(ColumnName = "JDR")]
        public string JDR { get; set; }
        /// <summary>
        /// 责任医生 
        /// </summary>
        [SugarColumn(ColumnName = "ZRYS")]
        public string ZRYS { get; set; }
        /// <summary>
        /// 建档日期 
        /// </summary>
        [SugarColumn(ColumnName = "JDRQ")]
        public DateTime JDRQ { get; set; }
        /// <summary>
        /// 家庭编号 
        /// </summary>
        [SugarColumn(ColumnName = "FH")]
        public string FH { get; set; }
        /// <summary>
        /// 性别 
        /// </summary>
        [SugarColumn(ColumnName = "XB")]
        public string XB { get; set; }
        /// <summary>
        /// 出生日期 
        /// </summary>
        [SugarColumn(ColumnName = "CSRQ")]
        public DateTime? CSRQ { get; set; }
        /// <summary>
        /// 身份证号 
        /// </summary>
        [SugarColumn(ColumnName = "SFZH")]
        public string SFZH { get; set; }
        /// <summary>
        /// 工作单位 
        /// </summary>
        [SugarColumn(ColumnName = "GZDW")]
        public string GZDW { get; set; }
        /// <summary>
        /// 本人电话 
        /// </summary>
        [SugarColumn(ColumnName = "BRDH")]
        public string BRDH { get; set; }
        /// <summary>
        /// 联系人姓名 
        /// </summary>
        [SugarColumn(ColumnName = "LXRXM")]
        public string LXRXM { get; set; }
        /// <summary>
        /// 联系人电话 
        /// </summary>
        [SugarColumn(ColumnName = "LXRDH")]
        public string LXRDH { get; set; }
        /// <summary>
        /// 常住类型 
        /// </summary>
        [SugarColumn(ColumnName = "CZLX")]
        public string CZLX { get; set; }
        /// <summary>
        /// 民族 
        /// </summary>
        [SugarColumn(ColumnName = "MZ")]
        public string MZ { get; set; }
        /// <summary>
        /// 血型 
        /// </summary>
        [SugarColumn(ColumnName = "XX")]
        public string XX { get; set; }
        /// <summary>
        /// RH阴性 
        /// </summary>
        [SugarColumn(ColumnName = "RHYX")]
        public string RHYX { get; set; }
        /// <summary>
        /// 文化程度 
        /// </summary>
        [SugarColumn(ColumnName = "WHCD")]
        public string WHCD { get; set; }
        /// <summary>
        /// 职业 
        /// </summary>
        [SugarColumn(ColumnName = "ZY")]
        public string ZY { get; set; }
        /// <summary>
        /// 婚姻状况 
        /// </summary>
        [SugarColumn(ColumnName = "HYZK")]
        public string HYZK { get; set; }
        /// <summary>
        /// 医疗费用支付方式 
        /// </summary>
        [SugarColumn(ColumnName = "YLFYZFFS")]
        public string YLFYZFFS { get; set; }
        /// <summary>
        /// 药物过敏史 
        /// </summary>
        [SugarColumn(ColumnName = "YWGMS")]
        public string YWGMS { get; set; }
        /// <summary>
        /// 遗传病史 
        /// </summary>
        [SugarColumn(ColumnName = "YCBS")]
        public string YCBS { get; set; }
        /// <summary>
        /// 残疾情况 
        /// </summary>
        [SugarColumn(ColumnName = "CJQK")]
        public string CJQK { get; set; }
        /// <summary>
        /// 机构编码 
        /// </summary>
        [SugarColumn(ColumnName = "JGBM")]
        public string JGBM { get; set; }
        /// <summary>
        /// 更新日期 
        /// </summary>
        [SugarColumn(ColumnName = "GXRQ")]
        public DateTime? GXRQ { get; set; }
        /// <summary>
        /// 查看密码 
        /// </summary>
        [SugarColumn(ColumnName = "MM")]
        public string MM { get; set; }
        /// <summary>
        /// 创建时间 
        /// 默认值: (getdate())
        /// </summary>
        [SugarColumn(ColumnName = "CJRQ")]
        public DateTime? CJRQ { get; set; }
        /// <summary>
        /// 户主标记 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "FZ")]
        public bool? FZ { get; set; }
        /// <summary>
        /// 与户主关系 
        /// </summary>
        [SugarColumn(ColumnName = "YFZGX")]
        public string YFZGX { get; set; }
        /// <summary>
        /// 厨房排风设施 
        /// </summary>
        [SugarColumn(ColumnName = "CFPFSS")]
        public string CFPFSS { get; set; }
        /// <summary>
        /// 燃料类型 
        /// </summary>
        [SugarColumn(ColumnName = "RLLX")]
        public string RLLX { get; set; }
        /// <summary>
        /// 饮水 
        /// </summary>
        [SugarColumn(ColumnName = "YS")]
        public string YS { get; set; }
        /// <summary>
        /// 厕所 
        /// </summary>
        [SugarColumn(ColumnName = "CS")]
        public string CS { get; set; }
        /// <summary>
        /// 禽畜栏 
        /// </summary>
        [SugarColumn(ColumnName = "CQL")]
        public string CQL { get; set; }
        /// <summary>
        /// 农合证号 
        /// </summary>
        [SugarColumn(ColumnName = "NHZH")]
        public string NHZH { get; set; }
        /// <summary>
        /// 户口类型 
        /// </summary>
        [SugarColumn(ColumnName = "FKLX")]
        public string FKLX { get; set; }
        /// <summary>
        /// 工号 
        /// </summary>
        [SugarColumn(ColumnName = "GH")]
        public string GH { get; set; }
        /// <summary>
        /// 是否及格,1是0否 
        /// </summary>
        [SugarColumn(ColumnName = "SFJG")]
        public bool? SFJG { get; set; }
        /// <summary>
        /// 评分 
        /// </summary>
        [SugarColumn(ColumnName = "PF")]
        public decimal? PF { get; set; }
        /// <summary>
        /// 孕产妇标记1表示是0表示否 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "YCF")]
        public bool YCF { get; set; }
        /// <summary>
        /// 计划免疫标识 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "JHMYBS")]
        public bool? JHMYBS { get; set; }
        /// <summary>
        /// 是否为高危人群 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "ISGWRQ")]
        public bool? ISGWRQ { get; set; }
        /// <summary>
        /// 原机构 
        /// </summary>
        [SugarColumn(ColumnName = "YJGBM")]
        public string YJGBM { get; set; }
        /// <summary>
        /// 孕产妇登记时间 
        /// </summary>
        [SugarColumn(ColumnName = "YCFDJSJ")]
        public DateTime? YCFDJSJ { get; set; }
        /// <summary>
        /// 废弃 
        /// </summary>
        [SugarColumn(ColumnName = "TG_CUNCODE")]
        public string TG_CUNCODE { get; set; }
        /// <summary>
        /// 儿童条码 
        /// </summary>
        [SugarColumn(ColumnName = "ETTM")]
        public string ETTM { get; set; }
        /// <summary>
        /// 状态 0：死亡 1：正常 2：长期失访 5：流出 
        /// 默认值: ((1))
        /// </summary>
        [SugarColumn(ColumnName = "ZT")]
        public int? ZT { get; set; }
        /// <summary>
        /// 旧档案号或纸质档案号 
        /// </summary>
        [SugarColumn(ColumnName = "OLDDAH")]
        public string OLDDAH { get; set; }
        /// <summary>
        /// 暴露史（已废弃） 
        /// </summary>
        [SugarColumn(ColumnName = "BLS")]
        public string BLS { get; set; }
        /// <summary>
        /// 废弃 
        /// </summary>
        [SugarColumn(ColumnName = "ZHXGGH")]
        public string ZHXGGH { get; set; }
        /// <summary>
        /// 废弃 
        /// </summary>
        [SugarColumn(ColumnName = "ZHXGSJ")]
        public DateTime? ZHXGSJ { get; set; }
        /// <summary>
        /// 是否高血压 
        /// 默认值: ('0')
        /// </summary>
        [SugarColumn(ColumnName = "SFGXY")]
        public string SFGXY { get; set; }
        /// <summary>
        /// 是否糖尿病 
        /// 默认值: ('0')
        /// </summary>
        [SugarColumn(ColumnName = "SFTNB")]
        public string SFTNB { get; set; }
        /// <summary>
        /// 是否精神病 
        /// 默认值: ('0')
        /// </summary>
        [SugarColumn(ColumnName = "SFJSB")]
        public string SFJSB { get; set; }
        /// <summary>
        /// 医疗费用支付方式 
        /// </summary>
        [SugarColumn(ColumnName = "YLFYZFFS2")]
        public string YLFYZFFS2 { get; set; }
        /// <summary>
        /// 药物过敏史 
        /// </summary>
        [SugarColumn(ColumnName = "YWGMS2")]
        public string YWGMS2 { get; set; }
        /// <summary>
        /// 暴露史 
        /// </summary>
        [SugarColumn(ColumnName = "BLS2")]
        public string BLS2 { get; set; }
        /// <summary>
        /// 医疗费用支付方式其他 
        /// </summary>
        [SugarColumn(ColumnName = "YLFYZFFS2QT")]
        public string YLFYZFFS2QT { get; set; }
        /// <summary>
        /// 其他药物过敏史 
        /// </summary>
        [SugarColumn(ColumnName = "YWGMS2QT")]
        public string YWGMS2QT { get; set; }
        /// <summary>
        /// 其他暴露史 
        /// </summary>
        [SugarColumn(ColumnName = "BLS2QT")]
        public string BLS2QT { get; set; }
        /// <summary>
        /// 无遗传病史 
        /// </summary>
        [SugarColumn(ColumnName = "YCBS2")]
        public string YCBS2 { get; set; }
        /// <summary>
        /// 有遗传病史 
        /// </summary>
        [SugarColumn(ColumnName = "YCBS2Y")]
        public string YCBS2Y { get; set; }
        /// <summary>
        /// 残疾情况 
        /// </summary>
        [SugarColumn(ColumnName = "CJQK2")]
        public string CJQK2 { get; set; }
        /// <summary>
        /// 其他残疾情况 
        /// </summary>
        [SugarColumn(ColumnName = "CJQK2QT")]
        public string CJQK2QT { get; set; }
        /// <summary>
        /// 现住址省 
        /// </summary>
        [SugarColumn(ColumnName = "XZZSHEN")]
        public string XZZSHEN { get; set; }
        /// <summary>
        /// 现住址市 
        /// </summary>
        [SugarColumn(ColumnName = "XZZSHI")]
        public string XZZSHI { get; set; }
        /// <summary>
        /// 现住址县 
        /// </summary>
        [SugarColumn(ColumnName = "XZZXIAN")]
        public string XZZXIAN { get; set; }
        /// <summary>
        /// 现住址镇 
        /// </summary>
        [SugarColumn(ColumnName = "XZZZHEN")]
        public string XZZZHEN { get; set; }
        /// <summary>
        /// 现住址居委会 
        /// </summary>
        [SugarColumn(ColumnName = "XZZJWH")]
        public string XZZJWH { get; set; }
        /// <summary>
        /// 现住址街道 
        /// </summary>
        [SugarColumn(ColumnName = "XZZJD")]
        public string XZZJD { get; set; }
        /// <summary>
        /// 户籍地址省 
        /// </summary>
        [SugarColumn(ColumnName = "HJDZSHEN")]
        public string HJDZSHEN { get; set; }
        /// <summary>
        /// 户籍地址市 
        /// </summary>
        [SugarColumn(ColumnName = "HJDZSHI")]
        public string HJDZSHI { get; set; }
        /// <summary>
        /// 户籍地址县 
        /// </summary>
        [SugarColumn(ColumnName = "HJDZXIAN")]
        public string HJDZXIAN { get; set; }
        /// <summary>
        /// 户籍地址镇 
        /// </summary>
        [SugarColumn(ColumnName = "HJDZZHEN")]
        public string HJDZZHEN { get; set; }
        /// <summary>
        /// 户籍地址居委会 
        /// </summary>
        [SugarColumn(ColumnName = "HJDZJWH")]
        public string HJDZJWH { get; set; }
        /// <summary>
        /// 户籍地址街道 
        /// </summary>
        [SugarColumn(ColumnName = "HJDZJD")]
        public string HJDZJD { get; set; }
        /// <summary>
        /// 最后修改人姓名 
        /// </summary>
        [SugarColumn(ColumnName = "vc_LastEditMan")]
        public string vc_LastEditMan { get; set; }
        /// <summary>
        /// 档案柜ID 
        /// </summary>
        [SugarColumn(ColumnName = "i_frame")]
        public string i_frame { get; set; }
        /// <summary>
        /// 档案柜X坐标 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "i_x")]
        public int? i_x { get; set; }
        /// <summary>
        /// 档案柜Y坐标 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "i_y")]
        public int? i_y { get; set; }
        /// <summary>
        /// 档案柜存储方式 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "i_depositway")]
        public int? i_depositway { get; set; }
        /// <summary>
        /// 档案柜名称 
        /// </summary>
        [SugarColumn(ColumnName = "vc_framename")]
        public string vc_framename { get; set; }
        /// <summary>
        ///  条形码 
        /// </summary>
        [SugarColumn(ColumnName = "vc_txm")]
        public string vc_txm { get; set; }
        /// <summary>
        /// 户籍流动情况 
        /// </summary>
        [SugarColumn(ColumnName = "VC_HJLDQK")]
        public string VC_HJLDQK { get; set; }
        /// <summary>
        /// 妇幼推送（0：否 1：是） 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "fyts")]
        public string fyts { get; set; }
        /// <summary>
        /// 是否补录（0：否 1：是） 
        /// 默认值: ('0')
        /// </summary>
        [SugarColumn(ColumnName = "isBuLu")]
        public string isBuLu { get; set; }
        /// <summary>
        /// 孕产妇登记GUID 
        /// </summary>
        [SugarColumn(ColumnName = "YCFDJID")]
        public string YCFDJID { get; set; }
        /// <summary>
        /// 可用标识（0：否 1：是） 
        /// 默认值: ((1))
        /// </summary>
        [SugarColumn(ColumnName = "KYBS")]
        public int? KYBS { get; set; }
        /// <summary>
        /// 肺结核（0：否 1：是） 
        /// 默认值: ('0')
        /// </summary>
        [SugarColumn(ColumnName = "fjh")]
        public int? fjh { get; set; }
        /// <summary>
        /// 现住址组名称 
        /// </summary>
        [SugarColumn(ColumnName = "XZZZU")]
        public string XZZZU { get; set; }
        /// <summary>
        /// 旧户号 
        /// </summary>
        [SugarColumn(ColumnName = "OLDFH")]
        public string OLDFH { get; set; }
        /// <summary>
        /// 年龄 
        /// </summary>
        [SugarColumn(ColumnName = "AGE")]
        public int AGE { get; set; }
        /// <summary>
        ///  数据来源 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "SJLY")]
        public int? SJLY { get; set; }
        /// <summary>
        /// 认证标识 0:未认证，1:已认证 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "RZBS")]
        public int? RZBS { get; set; }
        /// <summary>
        /// 认证人 
        /// </summary>
        [SugarColumn(ColumnName = "RZR")]
        public string RZR { get; set; }
        /// <summary>
        /// 认证时间 
        /// </summary>
        [SugarColumn(ColumnName = "RZSJ")]
        public DateTime? RZSJ { get; set; }
        /// <summary>
        /// 母亲身份证号 
        /// </summary>
        [SugarColumn(ColumnName = "MQSFZH")]
        public string MQSFZH { get; set; }
        /// <summary>
        /// 母亲姓名 
        /// </summary>
        [SugarColumn(ColumnName = "MQXM")]
        public string MQXM { get; set; }
        /// <summary>
        /// 是否有附件 0:没得附件,1:有附件 
        /// </summary>
        [SugarColumn(ColumnName = "ISFJ")]
        public int? ISFJ { get; set; }
        /// <summary>
        /// 是否签约（0：未签约 1：已签约） 
        /// 默认值: ('0')
        /// </summary>
        [SugarColumn(ColumnName = "SFQY")]
        public int? SFQY { get; set; }
        /// <summary>
        /// 是否残疾持证 0:否,1:是 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "ISCJCZ")]
        public int? ISCJCZ { get; set; }
        /// <summary>
        /// 微信关注（0：未关注，1：已关注） 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "WXGZ")]
        public int WXGZ { get; set; }
        /// <summary>
        /// 微信关注时间 
        /// </summary>
        [SugarColumn(ColumnName = "WXGZDATE")]
        public DateTime? WXGZDATE { get; set; }
        /// <summary>
        /// 身份证号是否有效 0:无效,1:有效 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "ISSFZHValid")]
        public int? ISSFZHValid { get; set; }
        /// <summary>
        /// 死亡时间 
        /// </summary>
        [SugarColumn(ColumnName = "SWSJ")]
        public DateTime? SWSJ { get; set; }
        /// <summary>
        /// 标签管理 
        /// </summary>
        [SugarColumn(ColumnName = "BQGL")]
        public string BQGL { get; set; }
        /// <summary>
        /// 最后服务日期 
        /// </summary>
        [SugarColumn(ColumnName = "LastFWdate")]
        public DateTime? LastFWdate { get; set; }
        /// <summary>
        /// 失能老年人评估记录(0:未评估 1：已评估) 
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "SNLNRPG")]
        public int? SNLNRPG { get; set; }
        /// <summary>
        /// 最早体检日期 
        /// </summary>
        [SugarColumn(ColumnName = "ZZTJRQ")]
        public DateTime? ZZTJRQ { get; set; }
        /// <summary>
        /// 是否注册健康码（0：未注册 1：已注册） 
        /// </summary>
        [SugarColumn(ColumnName = "SFZCJKM")]
        public int? SFZCJKM { get; set; }
        /// <summary>
        /// 健康码编码 
        /// </summary>
        [SugarColumn(ColumnName = "JKMBM")]
        public string JKMBM { get; set; }
        /// <summary>
        /// 微信关注推荐人工号 
        /// </summary>
        [SugarColumn(ColumnName = "WXGZTJRGH")]
        public string WXGZTJRGH { get; set; }
        /// <summary>
        ///  
        /// </summary>
        [SugarColumn(ColumnName = "RQSX")]
        public string RQSX { get; set; }
        /// <summary>
        /// 高血压登记日期 
        /// </summary>
        [SugarColumn(ColumnName = "GXYDJRQ")]
        public DateTime? GXYDJRQ { get; set; }
        /// <summary>
        /// 糖尿病登记日期 
        /// </summary>
        [SugarColumn(ColumnName = "TNBDJRQ")]
        public DateTime? TNBDJRQ { get; set; }
        /// <summary>
        /// 精神病登记日期 
        /// </summary>
        [SugarColumn(ColumnName = "JSBDJRQ")]
        public DateTime? JSBDJRQ { get; set; }
        /// <summary>
        /// 最后更新时间 
        /// 默认值: (getdate())
        /// </summary>
        [SugarColumn(ColumnName = "LastDateTime")]
        public DateTime LastDateTime { get; set; }
        /// <summary>
        ///  
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "SFGXZ")]
        public int? SFGXZ { get; set; }
        /// <summary>
        ///  
        /// 默认值: ((0))
        /// </summary>
        [SugarColumn(ColumnName = "SFBCB")]
        public int? SFBCB { get; set; }
        /// <summary>
        /// 是否冠心病（0：否 1：是） 
        /// </summary>
        [SugarColumn(ColumnName = "SFGXB")]
        public int? SFGXB { get; set; }
        /// <summary>
        /// 是否脑卒中（0：否 1：是） 
        /// </summary>
        [SugarColumn(ColumnName = "SFNCZ")]
        public int? SFNCZ { get; set; }
        /// <summary>
        /// 是否慢阻肺（0：否 1：是） 
        /// </summary>
        [SugarColumn(ColumnName = "SFMZF")]
        public int? SFMZF { get; set; }
        /// <summary>
        /// 是否慢肾病（0：否 1：是） 
        /// </summary>
        [SugarColumn(ColumnName = "SFMSB")]
        public int? SFMSB { get; set; }
        /// <summary>
        /// 身份证件类型 
        /// </summary>
        [SugarColumn(ColumnName = "ZJLX")]
        public string ZJLX { get; set; }
        /// <summary>
        /// 居民籍贯名称 
        /// </summary>
        [SugarColumn(ColumnName = "JMJGMC")]
        public string JMJGMC { get; set; }
        /// <summary>
        /// 居民出生地名称 
        /// </summary>
        [SugarColumn(ColumnName = "JMCSDMC")]
        public string JMCSDMC { get; set; }
        /// <summary>
        /// 第一紧急联系人关系（系统字典） 
        /// </summary>
        [SugarColumn(ColumnName = "DYJJLXRGX")]
        public string DYJJLXRGX { get; set; }
        /// <summary>
        /// 第二紧急联系人姓名 
        /// </summary>
        [SugarColumn(ColumnName = "DEJJLXRXM")]
        public string DEJJLXRXM { get; set; }
        /// <summary>
        /// 第二紧急联系人关系（系统字典） 
        /// </summary>
        [SugarColumn(ColumnName = "DEJJLXRGX")]
        public string DEJJLXRGX { get; set; }
        /// <summary>
        /// 药物过敏史其他药物 
        /// </summary>
        [SugarColumn(ColumnName = "YWGMS2QTYW")]
        public string YWGMS2QTYW { get; set; }
        /// <summary>
        /// 药物过敏史食物 
        /// </summary>
        [SugarColumn(ColumnName = "YWGMS2SW")]
        public string YWGMS2SW { get; set; }
        /// <summary>
        /// 是否合格 0合格 1不合格
        /// </summary>
        [SugarColumn(ColumnName = "ISHG")]
        public int ISHG { get; set; }
        /// <summary>
        /// 是否完整 0完整 1不完整
        /// </summary>
        [SugarColumn(ColumnName = "ISWZ")]
        public int ISWZ { get; set; }
    }
}
