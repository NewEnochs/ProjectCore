using SqlSugar;
using System;
using System.ComponentModel;

namespace Pro.Core.Model
{
    /// <summary>
    /// 机构管理
    ///</summary>
    [SugarTable("T_JGGL")]
    public class T_JGGL
    {
        /// <summary>
        /// id 
        ///</summary>
        [SugarColumn(ColumnName = "id", IsPrimaryKey = true, IsIdentity = true)]
        [DisplayName("id")]
        public int id { get; set; }
        /// <summary>
        /// Lavel 
        ///</summary>
        [SugarColumn(ColumnName = "Lavel")]
        [DisplayName("Lavel")]
        public byte Lavel { get; set; }
        /// <summary>
        /// 机构编码 
        ///</summary>
        [SugarColumn(ColumnName = "JGBM")]
        [DisplayName("机构编码")]
        public string JGBM { get; set; }
        /// <summary>
        /// 上一级机构编码 
        ///</summary>
        [SugarColumn(ColumnName = "PJGBM")]
        [DisplayName("上一级机构编码")]
        public string PJGBM { get; set; }
        /// <summary>
        /// 机构名称 
        ///</summary>
        [SugarColumn(ColumnName = "JGMC")]
        [DisplayName("机构名称")]
        public string JGMC { get; set; }
        /// <summary>
        /// 负责人 
        ///</summary>
        [SugarColumn(ColumnName = "FZR")]
        [DisplayName("负责人")]
        public string FZR { get; set; }
        /// <summary>
        /// 联系电话 
        ///</summary>
        [SugarColumn(ColumnName = "LXDH")]
        [DisplayName("联系电话")]
        public string LXDH { get; set; }
        /// <summary>
        /// 地址 
        ///</summary>
        [SugarColumn(ColumnName = "DZ")]
        [DisplayName("地址")]
        public string DZ { get; set; }
        /// <summary>
        /// QQ 
        ///</summary>
        [SugarColumn(ColumnName = "QQ")]
        [DisplayName("QQ")]
        public string QQ { get; set; }
        /// <summary>
        /// 邮编 
        ///</summary>
        [SugarColumn(ColumnName = "Email")]
        [DisplayName("邮编")]
        public string Email { get; set; }
        /// <summary>
        /// 创建日期 
        ///</summary>
        [SugarColumn(ColumnName = "CJRQ")]
        [DisplayName("创建日期")]
        public DateTime? CJRQ { get; set; }
        /// <summary>
        /// 注册码 
        ///</summary>
        [SugarColumn(ColumnName = "ZCM")]
        [DisplayName("注册码")]
        public string ZCM { get; set; }
        /// <summary>
        /// 注册状态 
        /// 默认值: (N'未注册')
        ///</summary>
        [SugarColumn(ColumnName = "ZCZT")]
        [DisplayName("注册状态")]
        public string ZCZT { get; set; }
        /// <summary>
        /// 机构权限 
        ///</summary>
        [SugarColumn(ColumnName = "Config")]
        [DisplayName("机构权限")]
        public string Config { get; set; }
        /// <summary>
        /// 机构类型(0:普通机构 1：镇级管理机构 2：县级管理机构) 
        /// 默认值: ((0))
        ///</summary>
        [SugarColumn(ColumnName = "JGLX")]
        [DisplayName("机构类型(0:普通机构 1：镇级管理机构 2：县级管理机构)")]
        public int? JGLX { get; set; }
        /// <summary>
        /// BBJGBM 
        ///</summary>
        [SugarColumn(ColumnName = "BBJGBM")]
        [DisplayName("BBJGBM")]
        public string BBJGBM { get; set; }
        /// <summary>
        /// GNKZ 
        ///</summary>
        [SugarColumn(ColumnName = "GNKZ")]
        [DisplayName("GNKZ")]
        public string GNKZ { get; set; }
        /// <summary>
        /// d_longitude 
        ///</summary>
        [SugarColumn(ColumnName = "d_longitude")]
        [DisplayName("d_longitude")]
        public decimal? d_longitude { get; set; }
        /// <summary>
        /// d_latitude 
        ///</summary>
        [SugarColumn(ColumnName = "d_latitude")]
        [DisplayName("d_latitude")]
        public decimal? d_latitude { get; set; }
        /// <summary>
        /// JGYTH 
        ///</summary>
        [SugarColumn(ColumnName = "JGYTH")]
        [DisplayName("JGYTH")]
        public int? JGYTH { get; set; }
        /// <summary>
        /// 地址省编码 
        ///</summary>
        [SugarColumn(ColumnName = "DZSHEN")]
        [DisplayName("地址省编码")]
        public string DZSHEN { get; set; }
        /// <summary>
        /// 地址市编码 
        ///</summary>
        [SugarColumn(ColumnName = "DZSHI")]
        [DisplayName("地址市编码")]
        public string DZSHI { get; set; }
        /// <summary>
        /// 地址县编码 
        ///</summary>
        [SugarColumn(ColumnName = "DZXIAN")]
        [DisplayName("地址县编码")]
        public string DZXIAN { get; set; }
        /// <summary>
        /// 地址镇编码 
        ///</summary>
        [SugarColumn(ColumnName = "DZZHEN")]
        [DisplayName("地址镇编码")]
        public string DZZHEN { get; set; }
        /// <summary>
        /// 地址村编码 
        ///</summary>
        [SugarColumn(ColumnName = "DZJWH")]
        [DisplayName("地址村编码")]
        public string DZJWH { get; set; }
        /// <summary>
        /// 邮编 
        ///</summary>
        [SugarColumn(ColumnName = "YB")]
        [DisplayName("邮编")]
        public string YB { get; set; }
        /// <summary>
        /// 法人姓名 
        ///</summary>
        [SugarColumn(ColumnName = "FRXM")]
        [DisplayName("法人姓名")]
        public string FRXM { get; set; }
        /// <summary>
        /// 法人电话 
        ///</summary>
        [SugarColumn(ColumnName = "FRDH")]
        [DisplayName("法人电话")]
        public string FRDH { get; set; }
        /// <summary>
        /// 机构介绍 
        ///</summary>
        [SugarColumn(ColumnName = "JGJS")]
        [DisplayName("机构介绍")]
        public string JGJS { get; set; }
        /// <summary>
        /// 机构工作时间 
        ///</summary>
        [SugarColumn(ColumnName = "JGGZSJ")]
        [DisplayName("机构工作时间")]
        public int? JGGZSJ { get; set; }
        /// <summary>
        /// 认知度和 
        ///</summary>
        [SugarColumn(ColumnName = "RXDH")]
        [DisplayName("认知度和")]
        public string RXDH { get; set; }
        /// <summary>
        /// 责任人姓名 
        ///</summary>
        [SugarColumn(ColumnName = "ZRRXM")]
        [DisplayName("责任人姓名")]
        public string ZRRXM { get; set; }
        /// <summary>
        /// 责任人电话 
        ///</summary>
        [SugarColumn(ColumnName = "ZRRDH")]
        [DisplayName("责任人电话")]
        public string ZRRDH { get; set; }
        /// <summary>
        /// 责任人性别 
        ///</summary>
        [SugarColumn(ColumnName = "ZRRXB")]
        [DisplayName("责任人性别")]
        public string ZRRXB { get; set; }
        /// <summary>
        /// 责任人邮箱 
        ///</summary>
        [SugarColumn(ColumnName = "ZRRBM")]
        [DisplayName("责任人邮箱")]
        public string ZRRBM { get; set; }
        /// <summary>
        /// 责任人职务 
        ///</summary>
        [SugarColumn(ColumnName = "ZRRZW")]
        [DisplayName("责任人职务")]
        public string ZRRZW { get; set; }
        /// <summary>
        /// 补充地址 
        ///</summary>
        [SugarColumn(ColumnName = "BCDZ")]
        [DisplayName("补充地址")]
        public string BCDZ { get; set; }
        /// <summary>
        /// 单位公章 
        ///</summary>
        [SugarColumn(ColumnName = "DWGZ")]
        [DisplayName("单位公章")]
        public string DWGZ { get; set; }
        /// <summary>
        /// 省平台统一机构编码 
        ///</summary>
        [SugarColumn(ColumnName = "SPTJGBM")]
        [DisplayName("省平台统一机构编码")]
        public string SPTJGBM { get; set; }
        /// <summary>
        /// 政府公章 
        ///</summary>
        [SugarColumn(ColumnName = "ZFGZ")]
        [DisplayName("政府公章")]
        public string ZFGZ { get; set; }
        /// <summary>
        /// 排序号 
        ///</summary>
        [SugarColumn(ColumnName = "IORDER")]
        [DisplayName("排序号")]
        public int? IORDER { get; set; }
        /// <summary>
        /// 是否统计机构 0:否，1:是 
        ///</summary>
        [SugarColumn(ColumnName = "ISTJJG")]
        [DisplayName("是否统计机构 0:否，1:是")]
        public int? ISTJJG { get; set; }
        /// <summary>
        /// 镇级编码 
        ///</summary>
        [SugarColumn(ColumnName = "ZJJGBM")]
        [DisplayName("镇级编码")]
        public string ZJJGBM { get; set; }
        /// <summary>
        /// 县级级编码 
        ///</summary>
        [SugarColumn(ColumnName = "XJJGBM")]
        [DisplayName("县级级编码")]
        public string XJJGBM { get; set; }
        /// <summary>
        /// 省级编码 
        ///</summary>
        [SugarColumn(ColumnName = "SJJGBM")]
        [DisplayName("省级编码")]
        public string SJJGBM { get; set; }
        /// <summary>
        /// 州/市级编码 
        ///</summary>
        [SugarColumn(ColumnName = "SHIJJGBM")]
        [DisplayName("州/市级编码")]
        public string SHIJJGBM { get; set; }
        /// <summary>
        /// 短信账号 
        ///</summary>
        [SugarColumn(ColumnName = "SMSZH")]
        [DisplayName("短信账号")]
        public string SMSZH { get; set; }
        /// <summary>
        /// 短信密码 
        ///</summary>
        [SugarColumn(ColumnName = "SMSMM")]
        [DisplayName("短信密码")]
        public string SMSMM { get; set; }
        /// <summary>
        /// 组织机构代码 
        ///</summary>
        [SugarColumn(ColumnName = "ZZJGDM")]
        [DisplayName("组织机构代码")]
        public string ZZJGDM { get; set; }
        /// <summary>
        /// 机构类型代码,参考国家字典MD05.03.022 
        ///</summary>
        [SugarColumn(ColumnName = "JGLXDM")]
        [DisplayName("机构类型代码,参考国家字典MD05.03.022")]
        public string JGLXDM { get; set; }
        /// <summary>
        /// 主办类型（1.政府办;2.个人办;3.社会办） 
        ///</summary>
        [SugarColumn(ColumnName = "JGZBLX")]
        [DisplayName("主办类型（1.政府办;2.个人办;3.社会办）")]
        public string JGZBLX { get; set; }
        /// <summary>
        /// 县级管理档案机构，默认0，启用为1 
        ///</summary>
        [SugarColumn(ColumnName = "SFXJGLDAJG")]
        [DisplayName("县级管理档案机构，默认0，启用为1")]
        public int? SFXJGLDAJG { get; set; }
        /// <summary>
        /// 平台机构代码 
        ///</summary>
        [SugarColumn(ColumnName = "PTOrganizationCode")]
        [DisplayName("平台机构代码")]
        public string PTOrganizationCode { get; set; }
        /// <summary>
        /// 平台用户名称 
        ///</summary>
        [SugarColumn(ColumnName = "PTUserName")]
        [DisplayName("平台用户名称")]
        public string PTUserName { get; set; }
        /// <summary>
        /// 平台用户密码 
        ///</summary>
        [SugarColumn(ColumnName = "PTPassword")]
        [DisplayName("平台用户密码")]
        public string PTPassword { get; set; }
        /// <summary>
        /// 平台独立地址 
        ///</summary>
        [SugarColumn(ColumnName = "PTCommonUrl")]
        [DisplayName("平台独立地址")]
        public string PTCommonUrl { get; set; }
        /// <summary>
        /// 预留参数1 
        ///</summary>
        [SugarColumn(ColumnName = "YWYLCS1")]
        [DisplayName("预留参数1")]
        public string YWYLCS1 { get; set; }
        /// <summary>
        /// 预留参数2 
        ///</summary>
        [SugarColumn(ColumnName = "YWYLCS2")]
        [DisplayName("预留参数2")]
        public string YWYLCS2 { get; set; }
        /// <summary>
        /// 预留参数3 
        ///</summary>
        [SugarColumn(ColumnName = "YWYLCS3")]
        [DisplayName("预留参数3")]
        public string YWYLCS3 { get; set; }
        /// <summary>
        /// HIS接口URL地址 
        ///</summary>
        [SugarColumn(ColumnName = "HISURL")]
        [DisplayName("HIS接口URL地址")]
        public string HISURL { get; set; }
        /// <summary>
        /// ECG接口URL地址 
        ///</summary>
        [SugarColumn(ColumnName = "ECGURL")]
        [DisplayName("ECG接口URL地址")]
        public string ECGURL { get; set; }
        /// <summary>
        /// LIS接口URL地址 
        ///</summary>
        [SugarColumn(ColumnName = "LISURL")]
        [DisplayName("LIS接口URL地址")]
        public string LISURL { get; set; }
        /// <summary>
        /// PACS接口URL地址 
        ///</summary>
        [SugarColumn(ColumnName = "PACSURL")]
        [DisplayName("PACS接口URL地址")]
        public string PACSURL { get; set; }
        /// <summary>
        /// 体检系统机构编码，如两个机构的值一致则使用相同的体检序号，空则使用JGBM字段区分 
        ///</summary>
        [SugarColumn(ColumnName = "PEJGBM")]
        [DisplayName("体检系统机构编码，如两个机构的值一致则使用相同的体检序号，空则使用JGBM字段区分")]
        public string PEJGBM { get; set; }
        /// <summary>
        /// 宣传页 
        ///</summary>
        [SugarColumn(ColumnName = "XCY")]
        [DisplayName("宣传页")]
        public string XCY { get; set; }
        /// <summary>
        /// 家庭签约宣传图 
        ///</summary>
        [SugarColumn(ColumnName = "JTQYXCT")]
        [DisplayName("家庭签约宣传图")]
        public string JTQYXCT { get; set; }
        /// <summary>
        /// 健康管理中心专用章 
        ///</summary>
        [SugarColumn(ColumnName = "JKGLZXZYZ")]
        [DisplayName("健康管理中心专用章")]
        public string JKGLZXZYZ { get; set; }
        /// <summary>
        /// 最后更新时间 
        ///</summary>
        [SugarColumn(ColumnName = "LASTDATETIME")]
        [DisplayName("最后更新时间")]
        public DateTime LASTDATETIME { get; set; }
        /// <summary>
        /// 机构管理增加LOGO图标 
        ///</summary>
        [SugarColumn(ColumnName = "LOGO")]
        [DisplayName("机构管理增加LOGO图标")]
        public string LOGO { get; set; }
        /// <summary>
        /// 开放体检预约（0：不开放 1：开放） 
        /// 默认值: ((0))
        ///</summary>
        [SugarColumn(ColumnName = "KFTJYY")]
        [DisplayName("开放体检预约（0：不开放 1：开放）")]
        public int? KFTJYY { get; set; }
        /// <summary>
        /// 级别 1省级医疗,2市级医疗,3县级管理,4县级医疗,5乡镇级医疗,6村级医疗 
        ///</summary>
        [SugarColumn(ColumnName = "TYPE")]
        [DisplayName("级别 1省级医疗,2市级医疗,3县级管理,4县级医疗,5乡镇级医疗,6村级医疗")]
        public int? TYPE { get; set; }
        /// <summary>
        /// 体检单位名称 
        ///</summary>
        [SugarColumn(ColumnName = "TJDWMC")]
        [DisplayName("体检单位名称")]
        public string TJDWMC { get; set; }
        /// <summary>
        /// 是否允许编辑健康教育种类管理 默认0不可编辑 1可编辑 
        /// 默认值: ((0))
        ///</summary>
        [SugarColumn(ColumnName = "ALLOW_EDIT_JKJYLX")]
        [DisplayName("是否允许编辑健康教育种类管理 默认0不可编辑 1可编辑")]
        public int? ALLOW_EDIT_JKJYLX { get; set; }
        /// <summary>
        /// 行政区划代码 
        ///</summary>
        [SugarColumn(ColumnName = "XZQHDM")]
        [DisplayName("行政区划代码")]
        public string XZQHDM { get; set; }
        /// <summary>
        /// 乡村一体化机构 （0：否 1：是） 
        /// 默认值: ((0))
        ///</summary>
        [SugarColumn(ColumnName = "XCYTHJG")]
        [DisplayName("乡村一体化机构 （0：否 1：是）")]
        public int? XCYTHJG { get; set; }
        /// <summary>
        /// 医共体管理机构编码 
        ///</summary>
        [SugarColumn(ColumnName = "YGTGLJGBM")]
        [DisplayName("医共体管理机构编码")]
        public string YGTGLJGBM { get; set; }

        [SugarColumn(ColumnName = "FWJGLX")]
        [DisplayName("服务机构类型")]
        public string? FWJGLX { get; set; }

        /// <summary>
        /// 医保机构编码 
        ///</summary>
        [SugarColumn(ColumnName = "YBJGBM")]
        [DisplayName("医保机构编码")]
        public string YBJGBM { get; set; }
        /// <summary>
        /// 医保机构名称 
        ///</summary>
        [SugarColumn(ColumnName = "YBJGMC")]
        [DisplayName("医保机构名称")]
        public string YBJGMC { get; set; }

        /// <summary> 
		/// 助产机构（0：否 1：是） 
		/// </summary> 
		[SugarColumn(ColumnName = "ZCJG", IsNullable = true)]
        public int ZCJG
        { get; set; }
    }
}
