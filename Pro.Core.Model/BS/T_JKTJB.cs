#region Using
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


#endregion

namespace Pro.Core.Model
{
    /// <summary> 
	/// 健康体检表 
	/// </summary> 
	[SugarTable("T_JKTJB", "健康体检表")]
    public class T_JKTJB
    {
        /// <summary> 
        /// id 
        /// </summary> 
        [SugarColumn(ColumnName = "id", IsIdentity = true)]
        public int id
        { get; set; }
        /// <summary> 
        /// 健康档案号 
        /// </summary> 
        [SugarColumn(ColumnName = "DAH", IsNullable = true, Length = 21)]
        public string DAH
        { get; set; }
        /// <summary> 
        /// 体检日期 
        /// </summary> 
        [SugarColumn(ColumnName = "TJRQ")]
        public DateTime TJRQ
        { get; set; }
        /// <summary> 
        /// 症状(废弃) 
        /// </summary> 
        [SugarColumn(ColumnName = "ZZ", IsNullable = true, Length = 200)]
        public string ZZ
        { get; set; }
        /// <summary> 
        /// 体温 
        /// </summary> 
        [SugarColumn(ColumnName = "TW", IsNullable = true, Length = 5)]
        public string TW
        { get; set; }
        /// <summary> 
        /// 脉率 
        /// </summary> 
        [SugarColumn(ColumnName = "ML", IsNullable = true)]
        public int ML
        { get; set; }
        /// <summary> 
        /// 呼吸频率 
        /// </summary> 
        [SugarColumn(ColumnName = "HXPL", IsNullable = true)]
        public int HXPL
        { get; set; }
        /// <summary> 
        /// 身高 
        /// </summary> 
        [SugarColumn(ColumnName = "SG", IsNullable = true, Length = 6)]
        public string SG
        { get; set; }
        /// <summary> 
        /// 体重 
        /// </summary> 
        [SugarColumn(ColumnName = "TZ", IsNullable = true, Length = 6)]
        public string TZ
        { get; set; }
        /// <summary> 
        /// 腰围 
        /// </summary> 
        [SugarColumn(ColumnName = "YW", IsNullable = true, Length = 6)]
        public string YW
        { get; set; }
        /// <summary> 
        /// 体质指数 
        /// </summary> 
        [SugarColumn(ColumnName = "TZZS", IsNullable = true, Length = 6)]
        public string TZZS
        { get; set; }
        /// <summary> 
        /// 臀围 
        /// </summary> 
        [SugarColumn(ColumnName = "TunWei", IsNullable = true, Length = 6)]
        public string TunWei
        { get; set; }
        /// <summary> 
        /// 腰臀围比值 
        /// </summary> 
        [SugarColumn(ColumnName = "YTBZ", IsNullable = true, Length = 10)]
        public string YTBZ
        { get; set; }
        /// <summary> 
        /// 老年人认知功能 
        /// </summary> 
        [SugarColumn(ColumnName = "LNRRZGN", IsNullable = true, Length = 30)]
        public string LNRRZGN
        { get; set; }
        /// <summary> 
        /// 老年人情感状态 
        /// </summary> 
        [SugarColumn(ColumnName = "LNRQGZD", IsNullable = true, Length = 30)]
        public string LNRQGZD
        { get; set; }
        /// <summary> 
        /// 锻炼频率 
        /// </summary> 
        [SugarColumn(ColumnName = "DLPL", IsNullable = true, Length = 20)]
        public string DLPL
        { get; set; }
        /// <summary> 
        /// 每次锻炼时间 
        /// </summary> 
        [SugarColumn(ColumnName = "MCDLSJ", IsNullable = true, Length = 10)]
        public string MCDLSJ
        { get; set; }
        /// <summary> 
        /// 坚持锻炼时间 
        /// </summary> 
        [SugarColumn(ColumnName = "JCDLSJ", IsNullable = true, Length = 5)]
        public string JCDLSJ
        { get; set; }
        /// <summary> 
        /// 锻炼方式 
        /// </summary> 
        [SugarColumn(ColumnName = "DLFS", IsNullable = true, Length = 20)]
        public string DLFS
        { get; set; }
        /// <summary> 
        /// 饮食习惯 
        /// </summary> 
        [SugarColumn(ColumnName = "YSXG", IsNullable = true, Length = 50)]
        public string YSXG
        { get; set; }
        /// <summary> 
        /// 吸烟状况 
        /// </summary> 
        [SugarColumn(ColumnName = "XYZK", IsNullable = true, Length = 10)]
        public string XYZK
        { get; set; }
        /// <summary> 
        /// 日吸烟量 
        /// </summary> 
        [SugarColumn(ColumnName = "RXYL", IsNullable = true)]
        public int RXYL
        { get; set; }
        /// <summary> 
        /// 开始吸烟年龄 
        /// </summary> 
        [SugarColumn(ColumnName = "KSXYNL", IsNullable = true, Length = 10)]
        public string KSXYNL
        { get; set; }
        /// <summary> 
        /// 戒烟年龄 
        /// </summary> 
        [SugarColumn(ColumnName = "JYNL", IsNullable = true, Length = 10)]
        public string JYNL
        { get; set; }
        /// <summary> 
        /// 饮酒频率 
        /// </summary> 
        [SugarColumn(ColumnName = "YJPL", IsNullable = true, Length = 10)]
        public string YJPL
        { get; set; }
        /// <summary> 
        /// 日饮酒量 
        /// </summary> 
        [SugarColumn(ColumnName = "RYJL", IsNullable = true, Length = 6)]
        public string RYJL
        { get; set; }
        /// <summary> 
        /// 是否戒酒 
        /// </summary> 
        [SugarColumn(ColumnName = "SFJJ", IsNullable = true, Length = 20)]
        public string SFJJ
        { get; set; }
        /// <summary> 
        /// 戒酒年龄 
        /// </summary> 
        [SugarColumn(ColumnName = "JJNL", IsNullable = true)]
        public int JJNL
        { get; set; }
        /// <summary> 
        /// 开始饮酒年龄 
        /// </summary> 
        [SugarColumn(ColumnName = "KSYJNL", IsNullable = true)]
        public int KSYJNL
        { get; set; }
        /// <summary> 
        /// 近一年内是否曾醉酒 
        /// </summary> 
        [SugarColumn(ColumnName = "JYNLSFZZJ", IsNullable = true, Length = 10)]
        public string JYNLSFZZJ
        { get; set; }
        /// <summary> 
        /// 饮酒种类 
        /// </summary> 
        [SugarColumn(ColumnName = "YJZL", IsNullable = true, Length = 20)]
        public string YJZL
        { get; set; }
        /// <summary> 
        /// 职业暴露情况 
        /// </summary> 
        [SugarColumn(ColumnName = "ZYBLQK", IsNullable = true, Length = 10)]
        public string ZYBLQK
        { get; set; }
        /// <summary> 
        /// 具体职业 
        /// </summary> 
        [SugarColumn(ColumnName = "JTZY", IsNullable = true, Length = 30)]
        public string JTZY
        { get; set; }
        /// <summary> 
        /// 从业时间 
        /// </summary> 
        [SugarColumn(ColumnName = "CYSJ", IsNullable = true, Length = 50)]
        public string CYSJ
        { get; set; }
        /// <summary> 
        /// 化学品 
        /// </summary> 
        [SugarColumn(ColumnName = "HXP", IsNullable = true, Length = 30)]
        public string HXP
        { get; set; }
        /// <summary> 
        /// 防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "HXPFFCS", IsNullable = true, Length = 20)]
        public string HXPFFCS
        { get; set; }
        /// <summary> 
        /// 毒物 
        /// </summary> 
        [SugarColumn(ColumnName = "DW", IsNullable = true, Length = 30)]
        public string DW
        { get; set; }
        /// <summary> 
        /// 防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "DWFFCS", IsNullable = true, Length = 20)]
        public string DWFFCS
        { get; set; }
        /// <summary> 
        /// 射线 
        /// </summary> 
        [SugarColumn(ColumnName = "SX", IsNullable = true, Length = 30)]
        public string SX
        { get; set; }
        /// <summary> 
        /// 防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "SXFFCS", IsNullable = true, Length = 20)]
        public string SXFFCS
        { get; set; }
        /// <summary> 
        /// 口唇 
        /// </summary> 
        [SugarColumn(ColumnName = "KC", IsNullable = true, Length = 20)]
        public string KC
        { get; set; }
        /// <summary> 
        /// 齿列 
        /// </summary> 
        [SugarColumn(ColumnName = "CL", IsNullable = true, Length = 50)]
        public string CL
        { get; set; }
        /// <summary> 
        /// 咽部 
        /// </summary> 
        [SugarColumn(ColumnName = "YB", IsNullable = true, Length = 20)]
        public string YB
        { get; set; }
        /// <summary> 
        /// 左眼视力 
        /// </summary> 
        [SugarColumn(ColumnName = "ZYSL", IsNullable = true, Length = 5)]
        public string ZYSL
        { get; set; }
        /// <summary> 
        /// 右眼视力 
        /// </summary> 
        [SugarColumn(ColumnName = "YYSL", IsNullable = true, Length = 5)]
        public string YYSL
        { get; set; }
        /// <summary> 
        /// 矫正视力 
        /// </summary> 
        [SugarColumn(ColumnName = "JZSL", IsNullable = true, Length = 10)]
        public string JZSL
        { get; set; }
        /// <summary> 
        /// 听力 
        /// </summary> 
        [SugarColumn(ColumnName = "TL", IsNullable = true, Length = 10)]
        public string TL
        { get; set; }
        /// <summary> 
        /// 运动功能 
        /// </summary> 
        [SugarColumn(ColumnName = "YDGN", IsNullable = true, Length = 30)]
        public string YDGN
        { get; set; }
        /// <summary> 
        /// 皮肤 
        /// </summary> 
        [SugarColumn(ColumnName = "PF", IsNullable = true, Length = 20)]
        public string PF
        { get; set; }
        /// <summary> 
        /// 巩膜 
        /// </summary> 
        [SugarColumn(ColumnName = "GM", IsNullable = true, Length = 20)]
        public string GM
        { get; set; }
        /// <summary> 
        /// 淋巴结 
        /// </summary> 
        [SugarColumn(ColumnName = "LBJ", IsNullable = true, Length = 20)]
        public string LBJ
        { get; set; }
        /// <summary> 
        /// 桶状胸 
        /// </summary> 
        [SugarColumn(ColumnName = "TZX", IsNullable = true, Length = 10)]
        public string TZX
        { get; set; }
        /// <summary> 
        /// 呼吸音 
        /// </summary> 
        [SugarColumn(ColumnName = "HXY", IsNullable = true, Length = 20)]
        public string HXY
        { get; set; }
        /// <summary> 
        /// 罗音 
        /// </summary> 
        [SugarColumn(ColumnName = "LY", IsNullable = true, Length = 20)]
        public string LY
        { get; set; }
        /// <summary> 
        /// 心率 
        /// </summary> 
        [SugarColumn(ColumnName = "XL", IsNullable = true)]
        public int XL
        { get; set; }
        /// <summary> 
        /// 心律 
        /// </summary> 
        [SugarColumn(ColumnName = "XinLu", IsNullable = true, Length = 20)]
        public string XinLu
        { get; set; }
        /// <summary> 
        /// 杂音 
        /// </summary> 
        [SugarColumn(ColumnName = "ZY", IsNullable = true, Length = 20)]
        public string ZY
        { get; set; }
        /// <summary> 
        /// 压痛 
        /// </summary> 
        [SugarColumn(ColumnName = "YT", IsNullable = true, Length = 20)]
        public string YT
        { get; set; }
        /// <summary> 
        /// 包块 
        /// </summary> 
        [SugarColumn(ColumnName = "BK", IsNullable = true, Length = 20)]
        public string BK
        { get; set; }
        /// <summary> 
        /// 肝大 
        /// </summary> 
        [SugarColumn(ColumnName = "GD", IsNullable = true, Length = 20)]
        public string GD
        { get; set; }
        /// <summary> 
        /// 脾大 
        /// </summary> 
        [SugarColumn(ColumnName = "PD", IsNullable = true, Length = 20)]
        public string PD
        { get; set; }
        /// <summary> 
        /// 移动性浊音 
        /// </summary> 
        [SugarColumn(ColumnName = "YDXZY", IsNullable = true, Length = 20)]
        public string YDXZY
        { get; set; }
        /// <summary> 
        /// 下肢水肿 
        /// </summary> 
        [SugarColumn(ColumnName = "XZSZ", IsNullable = true, Length = 20)]
        public string XZSZ
        { get; set; }
        /// <summary> 
        /// 足背动脉搏动 
        /// </summary> 
        [SugarColumn(ColumnName = "ZBDMBD", IsNullable = true, Length = 20)]
        public string ZBDMBD
        { get; set; }
        /// <summary> 
        /// 肛门指诊 
        /// </summary> 
        [SugarColumn(ColumnName = "GMZZ", IsNullable = true, Length = 20)]
        public string GMZZ
        { get; set; }
        /// <summary> 
        /// 乳腺 
        /// </summary> 
        [SugarColumn(ColumnName = "RX", IsNullable = true, Length = 50)]
        public string RX
        { get; set; }
        /// <summary> 
        /// 外阴 
        /// </summary> 
        [SugarColumn(ColumnName = "WY", IsNullable = true, Length = 20)]
        public string WY
        { get; set; }
        /// <summary> 
        /// 阴道 
        /// </summary> 
        [SugarColumn(ColumnName = "YD", IsNullable = true, Length = 20)]
        public string YD
        { get; set; }
        /// <summary> 
        /// 宫颈 
        /// </summary> 
        [SugarColumn(ColumnName = "GJ", IsNullable = true, Length = 20)]
        public string GJ
        { get; set; }
        /// <summary> 
        /// 宫体 
        /// </summary> 
        [SugarColumn(ColumnName = "GT", IsNullable = true, Length = 20)]
        public string GT
        { get; set; }
        /// <summary> 
        /// 附件 
        /// </summary> 
        [SugarColumn(ColumnName = "FJ", IsNullable = true, Length = 20)]
        public string FJ
        { get; set; }
        /// <summary> 
        /// 其他 
        /// </summary> 
        [SugarColumn(ColumnName = "FK_QT", IsNullable = true, Length = 200)]
        public string FK_QT
        { get; set; }
        /// <summary> 
        /// 血红蛋白 
        /// </summary> 
        [SugarColumn(ColumnName = "HB", IsNullable = true, Length = 10)]
        public string HB
        { get; set; }
        /// <summary> 
        /// 白细胞 
        /// </summary> 
        [SugarColumn(ColumnName = "WBC", IsNullable = true, Length = 20)]
        public string WBC
        { get; set; }
        /// <summary> 
        /// 血小板 
        /// </summary> 
        [SugarColumn(ColumnName = "PLT", IsNullable = true, Length = 20)]
        public string PLT
        { get; set; }
        /// <summary> 
        /// 其他 
        /// </summary> 
        [SugarColumn(ColumnName = "XCG_QT", IsNullable = true, Length = 256)]
        public string XCG_QT
        { get; set; }
        /// <summary> 
        /// 尿蛋白 
        /// </summary> 
        [SugarColumn(ColumnName = "NDB", IsNullable = true, Length = 20)]
        public string NDB
        { get; set; }
        /// <summary> 
        /// 尿糖 
        /// </summary> 
        [SugarColumn(ColumnName = "NT", IsNullable = true, Length = 20)]
        public string NT
        { get; set; }
        /// <summary> 
        /// 尿酮体 
        /// </summary> 
        [SugarColumn(ColumnName = "NTT", IsNullable = true, Length = 20)]
        public string NTT
        { get; set; }
        /// <summary> 
        /// 尿潜血 
        /// </summary> 
        [SugarColumn(ColumnName = "NJX", IsNullable = true, Length = 20)]
        public string NJX
        { get; set; }
        /// <summary> 
        /// 其他 
        /// </summary> 
        [SugarColumn(ColumnName = "NCG_QT", IsNullable = true, Length = 256)]
        public string NCG_QT
        { get; set; }
        /// <summary> 
        /// 尿微量白蛋白 
        /// </summary> 
        [SugarColumn(ColumnName = "NWLBDB", IsNullable = true, Length = 20)]
        public string NWLBDB
        { get; set; }
        /// <summary> 
        /// 大便潜血 
        /// </summary> 
        [SugarColumn(ColumnName = "DBJX", IsNullable = true, Length = 10)]
        public string DBJX
        { get; set; }
        /// <summary> 
        /// 血清谷丙转氨酶 
        /// </summary> 
        [SugarColumn(ColumnName = "ALT", IsNullable = true, Length = 10)]
        public string ALT
        { get; set; }
        /// <summary> 
        /// 血清谷草转氨酶 
        /// </summary> 
        [SugarColumn(ColumnName = "AST", IsNullable = true, Length = 10)]
        public string AST
        { get; set; }
        /// <summary> 
        /// 白蛋白 
        /// </summary> 
        [SugarColumn(ColumnName = "BDB", IsNullable = true, Length = 10)]
        public string BDB
        { get; set; }
        /// <summary> 
        /// 总胆红素 
        /// </summary> 
        [SugarColumn(ColumnName = "ZDHS", IsNullable = true, Length = 10)]
        public string ZDHS
        { get; set; }
        /// <summary> 
        /// 结合胆红素 
        /// </summary> 
        [SugarColumn(ColumnName = "JHDHS", IsNullable = true, Length = 10)]
        public string JHDHS
        { get; set; }
        /// <summary> 
        /// 血清肌酐 
        /// </summary> 
        [SugarColumn(ColumnName = "XQJG", IsNullable = true, Length = 10)]
        public string XQJG
        { get; set; }
        /// <summary> 
        /// 血尿素氮 
        /// </summary> 
        [SugarColumn(ColumnName = "XNSD", IsNullable = true, Length = 10)]
        public string XNSD
        { get; set; }
        /// <summary> 
        /// 血钾浓度 
        /// </summary> 
        [SugarColumn(ColumnName = "XJND", IsNullable = true, Length = 10)]
        public string XJND
        { get; set; }
        /// <summary> 
        /// 血钠浓度 
        /// </summary> 
        [SugarColumn(ColumnName = "XNND", IsNullable = true, Length = 10)]
        public string XNND
        { get; set; }
        /// <summary> 
        /// 总胆固醇 
        /// </summary> 
        [SugarColumn(ColumnName = "ZDGC", IsNullable = true, Length = 10)]
        public string ZDGC
        { get; set; }
        /// <summary> 
        /// 甘油三酯 
        /// </summary> 
        [SugarColumn(ColumnName = "GYSZ", IsNullable = true, Length = 10)]
        public string GYSZ
        { get; set; }
        /// <summary> 
        /// 血清低密度脂蛋白胆固醇 
        /// </summary> 
        [SugarColumn(ColumnName = "HDL", IsNullable = true, Length = 10)]
        public string HDL
        { get; set; }
        /// <summary> 
        /// 血清高密度脂蛋白胆固醇 
        /// </summary> 
        [SugarColumn(ColumnName = "HDH", IsNullable = true, Length = 10)]
        public string HDH
        { get; set; }
        /// <summary> 
        /// 糖化血红蛋白 
        /// </summary> 
        [SugarColumn(ColumnName = "DHXHDB", IsNullable = true, Length = 10)]
        public string DHXHDB
        { get; set; }
        /// <summary> 
        /// 乙型肝炎表面抗原 
        /// </summary> 
        [SugarColumn(ColumnName = "HSAg", IsNullable = true, Length = 10)]
        public string HSAg
        { get; set; }
        /// <summary> 
        /// 眼底 
        /// </summary> 
        [SugarColumn(ColumnName = "YanDi", IsNullable = true, Length = 30)]
        public string YanDi
        { get; set; }
        /// <summary> 
        /// 心电图 
        /// </summary> 
        [SugarColumn(ColumnName = "XDT", IsNullable = true, Length = 30)]
        public string XDT
        { get; set; }
        /// <summary> 
        /// 胸部X线片 
        /// </summary> 
        [SugarColumn(ColumnName = "XX", IsNullable = true, Length = 128)]
        public string XX
        { get; set; }
        /// <summary> 
        /// B超 
        /// </summary> 
        [SugarColumn(ColumnName = "BC", IsNullable = true, Length = 30)]
        public string BC
        { get; set; }
        /// <summary> 
        /// 宫颈涂片 
        /// </summary> 
        [SugarColumn(ColumnName = "GJTP", IsNullable = true, Length = 30)]
        public string GJTP
        { get; set; }
        /// <summary> 
        /// 其他 
        /// </summary> 
        [SugarColumn(ColumnName = "FZJC_QT", IsNullable = true, Length = 100)]
        public string FZJC_QT
        { get; set; }
        /// <summary> 
        /// 平和质 
        /// </summary> 
        [SugarColumn(ColumnName = "PHZ", IsNullable = true, Length = 30)]
        public string PHZ
        { get; set; }
        /// <summary> 
        /// 气虚质 
        /// </summary> 
        [SugarColumn(ColumnName = "QXZ", IsNullable = true, Length = 30)]
        public string QXZ
        { get; set; }
        /// <summary> 
        /// 阳虚质 
        /// </summary> 
        [SugarColumn(ColumnName = "YXZ", IsNullable = true, Length = 30)]
        public string YXZ
        { get; set; }
        /// <summary> 
        /// 阴虚质 
        /// </summary> 
        [SugarColumn(ColumnName = "ZY_YXZ", IsNullable = true, Length = 30)]
        public string ZY_YXZ
        { get; set; }
        /// <summary> 
        /// 痰湿质 
        /// </summary> 
        [SugarColumn(ColumnName = "TSZ", IsNullable = true, Length = 30)]
        public string TSZ
        { get; set; }
        /// <summary> 
        /// 湿热质 
        /// </summary> 
        [SugarColumn(ColumnName = "SRZ", IsNullable = true, Length = 30)]
        public string SRZ
        { get; set; }
        /// <summary> 
        /// 血瘀质 
        /// </summary> 
        [SugarColumn(ColumnName = "XYZ", IsNullable = true, Length = 30)]
        public string XYZ
        { get; set; }
        /// <summary> 
        /// 气郁质 
        /// </summary> 
        [SugarColumn(ColumnName = "QYZ", IsNullable = true, Length = 30)]
        public string QYZ
        { get; set; }
        /// <summary> 
        /// 特秉质 
        /// </summary> 
        [SugarColumn(ColumnName = "TBZ", IsNullable = true, Length = 30)]
        public string TBZ
        { get; set; }
        /// <summary> 
        /// 脑血管疾病 
        /// </summary> 
        [SugarColumn(ColumnName = "NXGJB", IsNullable = true, Length = 100)]
        public string NXGJB
        { get; set; }
        /// <summary> 
        /// 肾脏疾病 
        /// </summary> 
        [SugarColumn(ColumnName = "SZJB", IsNullable = true, Length = 100)]
        public string SZJB
        { get; set; }
        /// <summary> 
        /// 心脏疾病 
        /// </summary> 
        [SugarColumn(ColumnName = "XZJB", IsNullable = true, Length = 100)]
        public string XZJB
        { get; set; }
        /// <summary> 
        /// 血管疾病 
        /// </summary> 
        [SugarColumn(ColumnName = "XGJB", IsNullable = true, Length = 100)]
        public string XGJB
        { get; set; }
        /// <summary> 
        /// 眼部疾病 
        /// </summary> 
        [SugarColumn(ColumnName = "YBJB", IsNullable = true, Length = 100)]
        public string YBJB
        { get; set; }
        /// <summary> 
        /// 神经系统疾病 
        /// </summary> 
        [SugarColumn(ColumnName = "SJXTJB", IsNullable = true, Length = 30)]
        public string SJXTJB
        { get; set; }
        /// <summary> 
        /// 其他系统疾病 
        /// </summary> 
        [SugarColumn(ColumnName = "QTXTJB", IsNullable = true, Length = 100)]
        public string QTXTJB
        { get; set; }
        /// <summary> 
        /// 住院史 
        /// </summary> 
        [SugarColumn(ColumnName = "ZYS", IsNullable = true, Length = 800)]
        public string ZYS
        { get; set; }
        /// <summary> 
        /// 家庭病床史 
        /// </summary> 
        [SugarColumn(ColumnName = "JTBCS", IsNullable = true, Length = 800)]
        public string JTBCS
        { get; set; }
        /// <summary> 
        /// 主要用药情况 
        /// </summary> 
        [SugarColumn(ColumnName = "YYYYQK", IsNullable = true, Length = 2000)]
        public string YYYYQK
        { get; set; }
        /// <summary> 
        /// 非免疫规划预防接种史 
        /// </summary> 
        [SugarColumn(ColumnName = "FMYGHYBJZS", IsNullable = true, Length = 800)]
        public string FMYGHYBJZS
        { get; set; }
        /// <summary> 
        /// 健康评价 
        /// </summary> 
        [SugarColumn(ColumnName = "JKPJ", IsNullable = true, Length = 800)]
        public string JKPJ
        { get; set; }
        /// <summary> 
        /// 危险因素控制 
        /// </summary> 
        [SugarColumn(ColumnName = "WXYSKZ", IsNullable = true, Length = 100)]
        public string WXYSKZ
        { get; set; }
        /// <summary> 
        /// 操作员 
        /// </summary> 
        [SugarColumn(ColumnName = "CZY", IsNullable = true, Length = 30)]
        public string CZY
        { get; set; }
        /// <summary> 
        /// 老年人健康状态自我评估 
        /// </summary> 
        [SugarColumn(ColumnName = "LNR_JKZTZWPG", IsNullable = true, Length = 50)]
        public string LNR_JKZTZWPG
        { get; set; }
        /// <summary> 
        /// 老年人生活能力自我评估 
        /// </summary> 
        [SugarColumn(ColumnName = "LNR_SHNLZWPG", IsNullable = true, Length = 50)]
        public string LNR_SHNLZWPG
        { get; set; }
        /// <summary> 
        /// 生活质量评分 
        /// </summary> 
        [SugarColumn(ColumnName = "SF36", IsNullable = true, Length = 30)]
        public string SF36
        { get; set; }
        /// <summary> 
        /// 外耳情况 
        /// </summary> 
        [SugarColumn(ColumnName = "WE", IsNullable = true, Length = 30)]
        public string WE
        { get; set; }
        /// <summary> 
        /// 色觉情况 
        /// </summary> 
        [SugarColumn(ColumnName = "SJ", IsNullable = true, Length = 30)]
        public string SJ
        { get; set; }
        /// <summary> 
        /// 眼底情况 
        /// </summary> 
        [SugarColumn(ColumnName = "Y_YD", IsNullable = true, Length = 30)]
        public string Y_YD
        { get; set; }
        /// <summary> 
        /// 视力其它异常 
        /// </summary> 
        [SugarColumn(ColumnName = "QTYC", IsNullable = true, Length = 100)]
        public string QTYC
        { get; set; }
        /// <summary> 
        /// 鼻结构 
        /// </summary> 
        [SugarColumn(ColumnName = "B_JG", IsNullable = true, Length = 30)]
        public string B_JG
        { get; set; }
        /// <summary> 
        /// 鼻窦情况 
        /// </summary> 
        [SugarColumn(ColumnName = "B_BD", IsNullable = true, Length = 30)]
        public string B_BD
        { get; set; }
        /// <summary> 
        /// 鼻嗅觉情况 
        /// </summary> 
        [SugarColumn(ColumnName = "B_XJ", IsNullable = true, Length = 30)]
        public string B_XJ
        { get; set; }
        /// <summary> 
        /// 鼻其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "B_QT", IsNullable = true, Length = 100)]
        public string B_QT
        { get; set; }
        /// <summary> 
        /// 口腔黏膜情况 
        /// </summary> 
        [SugarColumn(ColumnName = "K_NM", IsNullable = true, Length = 30)]
        public string K_NM
        { get; set; }
        /// <summary> 
        /// 口腔牙龈情况 
        /// </summary> 
        [SugarColumn(ColumnName = "K_YY", IsNullable = true, Length = 30)]
        public string K_YY
        { get; set; }
        /// <summary> 
        /// 腹部听诊 
        /// </summary> 
        [SugarColumn(ColumnName = "FB_TZ", IsNullable = true, Length = 50)]
        public string FB_TZ
        { get; set; }
        /// <summary> 
        /// 腹部视诊情况 
        /// </summary> 
        [SugarColumn(ColumnName = "FB_SZ", IsNullable = true, Length = 50)]
        public string FB_SZ
        { get; set; }
        /// <summary> 
        /// 腹部叩诊 
        /// </summary> 
        [SugarColumn(ColumnName = "FB_KZ", IsNullable = true, Length = 50)]
        public string FB_KZ
        { get; set; }
        /// <summary> 
        /// 腹部双肾叩击痛 
        /// </summary> 
        [SugarColumn(ColumnName = "FB_SSKJT", IsNullable = true, Length = 50)]
        public string FB_SSKJT
        { get; set; }
        /// <summary> 
        /// 四肢关节情况 
        /// </summary> 
        [SugarColumn(ColumnName = "YD_SZGJ", IsNullable = true, Length = 30)]
        public string YD_SZGJ
        { get; set; }
        /// <summary> 
        /// 脊柱情况 
        /// </summary> 
        [SugarColumn(ColumnName = "YD_JZ", IsNullable = true, Length = 30)]
        public string YD_JZ
        { get; set; }
        /// <summary> 
        /// 尿常规外观 
        /// </summary> 
        [SugarColumn(ColumnName = "NCG_WG", IsNullable = true, Length = 30)]
        public string NCG_WG
        { get; set; }
        /// <summary> 
        /// 尿常规细胞 
        /// </summary> 
        [SugarColumn(ColumnName = "NCG_XB", IsNullable = true, Length = 30)]
        public string NCG_XB
        { get; set; }
        /// <summary> 
        /// 大便隐血情况 
        /// </summary> 
        [SugarColumn(ColumnName = "DB_YX", IsNullable = true, Length = 30)]
        public string DB_YX
        { get; set; }
        /// <summary> 
        /// 口腔卫生是否刷牙 
        /// </summary> 
        [SugarColumn(ColumnName = "KQ_SFSY", IsNullable = true, Length = 30)]
        public string KQ_SFSY
        { get; set; }
        /// <summary> 
        /// 口腔卫生刷牙频率 
        /// </summary> 
        [SugarColumn(ColumnName = "KQ_SYPL", IsNullable = true, Length = 30)]
        public string KQ_SYPL
        { get; set; }
        /// <summary> 
        /// 主要负性生活事件 
        /// </summary> 
        [SugarColumn(ColumnName = "SH_SHSJ", IsNullable = true, Length = 50)]
        public string SH_SHSJ
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_消化系统疾病 
        /// </summary> 
        [SugarColumn(ColumnName = "JK_XHJB", IsNullable = true, Length = 200)]
        public string JK_XHJB
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_呼吸系统疾病 
        /// </summary> 
        [SugarColumn(ColumnName = "JK_FXJB", IsNullable = true, Length = 200)]
        public string JK_FXJB
        { get; set; }
        /// <summary> 
        /// XY_MR 
        /// </summary> 
        [SugarColumn(ColumnName = "XY_MR", IsNullable = true, Length = 10)]
        public string XY_MR
        { get; set; }
        /// <summary> 
        /// 糖尿病足背动脉搏动情况 
        /// </summary> 
        [SugarColumn(ColumnName = "TNB_ZBDMBD", IsNullable = true, Length = 30)]
        public string TNB_ZBDMBD
        { get; set; }
        /// <summary> 
        /// 糖化血红蛋白百分比 
        /// </summary> 
        [SugarColumn(ColumnName = "TNB_THXHDB", IsNullable = true, Length = 10)]
        public string TNB_THXHDB
        { get; set; }
        /// <summary> 
        /// 高血压血生化K+ 
        /// </summary> 
        [SugarColumn(ColumnName = "GXY_K", IsNullable = true, Length = 30)]
        public string GXY_K
        { get; set; }
        /// <summary> 
        /// 高血压NA+ 
        /// </summary> 
        [SugarColumn(ColumnName = "GXY_Na", IsNullable = true, Length = 30)]
        public string GXY_Na
        { get; set; }
        /// <summary> 
        /// copd咳嗽症状 
        /// </summary> 
        [SugarColumn(ColumnName = "ZZ_KS", IsNullable = true, Length = 200)]
        public string ZZ_KS
        { get; set; }
        /// <summary> 
        /// COPD咯痰症状 
        /// </summary> 
        [SugarColumn(ColumnName = "ZZ_LT", IsNullable = true, Length = 200)]
        public string ZZ_LT
        { get; set; }
        /// <summary> 
        /// COPD呼吸困难症状 
        /// </summary> 
        [SugarColumn(ColumnName = "ZZ_HXKN", IsNullable = true, Length = 200)]
        public string ZZ_HXKN
        { get; set; }
        /// <summary> 
        /// 查体口唇紫绀 
        /// </summary> 
        [SugarColumn(ColumnName = "CT_KCZG", IsNullable = true, Length = 30)]
        public string CT_KCZG
        { get; set; }
        /// <summary> 
        /// 查体劲静脉 
        /// </summary> 
        [SugarColumn(ColumnName = "CT_JJM", IsNullable = true, Length = 30)]
        public string CT_JJM
        { get; set; }
        /// <summary> 
        /// 查体_哮鸣音 
        /// </summary> 
        [SugarColumn(ColumnName = "CT_XWY", IsNullable = true, Length = 200)]
        public string CT_XWY
        { get; set; }
        /// <summary> 
        /// 特殊人群检查_6分钟步行距离 
        /// </summary> 
        [SugarColumn(ColumnName = "QT_BXJL", IsNullable = true, Length = 30)]
        public string QT_BXJL
        { get; set; }
        /// <summary> 
        /// 特殊人群检查_血氧饱和度 
        /// </summary> 
        [SugarColumn(ColumnName = "XYBHD_SaO2", IsNullable = true, Length = 10)]
        public string XYBHD_SaO2
        { get; set; }
        /// <summary> 
        /// COPD患者生活质量 SGRQ评分 
        /// </summary> 
        [SugarColumn(ColumnName = "SHZL_SGRQ", IsNullable = true, Length = 30)]
        public string SHZL_SGRQ
        { get; set; }
        /// <summary> 
        /// 特殊人群检查_肺功能FEVI/FVC 
        /// </summary> 
        [SugarColumn(ColumnName = "GGN_FVC", IsNullable = true, Length = 10)]
        public string GGN_FVC
        { get; set; }
        /// <summary> 
        /// 特殊人群检查_肺功能FEVI 
        /// </summary> 
        [SugarColumn(ColumnName = "GGN_FEVI", IsNullable = true, Length = 10)]
        public string GGN_FEVI
        { get; set; }
        /// <summary> 
        /// 毒物种类其他 
        /// </summary> 
        [SugarColumn(ColumnName = "DW_QT", IsNullable = true, Length = 30)]
        public string DW_QT
        { get; set; }
        /// <summary> 
        /// 毒物粉尘 
        /// </summary> 
        [SugarColumn(ColumnName = "FC", IsNullable = true, Length = 30)]
        public string FC
        { get; set; }
        /// <summary> 
        /// 毒物粉尘防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "FCFFCS", IsNullable = true, Length = 20)]
        public string FCFFCS
        { get; set; }
        /// <summary> 
        /// 毒物物理因素 
        /// </summary> 
        [SugarColumn(ColumnName = "WL", IsNullable = true, Length = 30)]
        public string WL
        { get; set; }
        /// <summary> 
        /// 毒物物理因素防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "WLFFCS", IsNullable = true, Length = 20)]
        public string WLFFCS
        { get; set; }
        /// <summary> 
        /// 脏器功能其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "QT", IsNullable = true, Length = 30)]
        public string QT
        { get; set; }
        /// <summary> 
        /// 毒物其他防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "QTFFCS", IsNullable = true, Length = 20)]
        public string QTFFCS
        { get; set; }
        /// <summary> 
        /// 辅助检查空腹血糖 
        /// </summary> 
        [SugarColumn(ColumnName = "KFXT1", IsNullable = true)]
        public decimal KFXT1
        { get; set; }
        /// <summary> 
        /// 脏器功能矫正视力右 
        /// </summary> 
        [SugarColumn(ColumnName = "JZSL_Right", IsNullable = true, Length = 10)]
        public string JZSL_Right
        { get; set; }
        /// <summary> 
        /// 龋齿左上 
        /// </summary> 
        [SugarColumn(ColumnName = "QC_LeftUp", IsNullable = true, Length = 64)]
        public string QC_LeftUp
        { get; set; }
        /// <summary> 
        /// 龋齿左下 
        /// </summary> 
        [SugarColumn(ColumnName = "QC_LeftDown", IsNullable = true, Length = 64)]
        public string QC_LeftDown
        { get; set; }
        /// <summary> 
        /// 龋齿右上 
        /// </summary> 
        [SugarColumn(ColumnName = "QC_RightUp", IsNullable = true, Length = 64)]
        public string QC_RightUp
        { get; set; }
        /// <summary> 
        /// 龋齿右下 
        /// </summary> 
        [SugarColumn(ColumnName = "QC_RightDown", IsNullable = true, Length = 64)]
        public string QC_RightDown
        { get; set; }
        /// <summary> 
        /// 义齿左上 
        /// </summary> 
        [SugarColumn(ColumnName = "Yc_LeftUp", IsNullable = true, Length = 64)]
        public string Yc_LeftUp
        { get; set; }
        /// <summary> 
        /// 义齿左下 
        /// </summary> 
        [SugarColumn(ColumnName = "YC_LeftDown", IsNullable = true, Length = 64)]
        public string YC_LeftDown
        { get; set; }
        /// <summary> 
        /// 义齿右上 
        /// </summary> 
        [SugarColumn(ColumnName = "YC_RightUp", IsNullable = true, Length = 64)]
        public string YC_RightUp
        { get; set; }
        /// <summary> 
        /// 义齿右下 
        /// </summary> 
        [SugarColumn(ColumnName = "YC_RightDown", IsNullable = true, Length = 64)]
        public string YC_RightDown
        { get; set; }
        /// <summary> 
        /// 假牙左上 
        /// </summary> 
        [SugarColumn(ColumnName = "JY_LeftUp", IsNullable = true, Length = 64)]
        public string JY_LeftUp
        { get; set; }
        /// <summary> 
        /// 假牙左下 
        /// </summary> 
        [SugarColumn(ColumnName = "JY_LeftDown", IsNullable = true, Length = 64)]
        public string JY_LeftDown
        { get; set; }
        /// <summary> 
        /// 假牙右上 
        /// </summary> 
        [SugarColumn(ColumnName = "JY_RightUp", IsNullable = true, Length = 64)]
        public string JY_RightUp
        { get; set; }
        /// <summary> 
        /// 假牙右下 
        /// </summary> 
        [SugarColumn(ColumnName = "JY_RightDown", IsNullable = true, Length = 64)]
        public string JY_RightDown
        { get; set; }
        /// <summary> 
        /// 个人生活料理 
        /// </summary> 
        [SugarColumn(ColumnName = "GRSHLL", IsNullable = true, Length = 30)]
        public string GRSHLL
        { get; set; }
        /// <summary> 
        /// 家务劳动 
        /// </summary> 
        [SugarColumn(ColumnName = "JWLD", IsNullable = true, Length = 30)]
        public string JWLD
        { get; set; }
        /// <summary> 
        /// 生产劳动及工作 
        /// </summary> 
        [SugarColumn(ColumnName = "SCLDJGZ", IsNullable = true, Length = 30)]
        public string SCLDJGZ
        { get; set; }
        /// <summary> 
        /// 学习能力 
        /// </summary> 
        [SugarColumn(ColumnName = "XXNL", IsNullable = true, Length = 30)]
        public string XXNL
        { get; set; }
        /// <summary> 
        /// 社会人际关系交往 
        /// </summary> 
        [SugarColumn(ColumnName = "RJJWGX", IsNullable = true, Length = 30)]
        public string RJJWGX
        { get; set; }
        /// <summary> 
        /// 患者对家庭的影响 
        /// </summary> 
        [SugarColumn(ColumnName = "HZDJDYX", IsNullable = true, Length = 100)]
        public string HZDJDYX
        { get; set; }
        /// <summary> 
        /// 关锁情况 
        /// </summary> 
        [SugarColumn(ColumnName = "GSQK", IsNullable = true, Length = 30)]
        public string GSQK
        { get; set; }
        /// <summary> 
        /// 健康体检评价 
        /// </summary> 
        [SugarColumn(ColumnName = "JKTJPJ", IsNullable = true, Length = 500)]
        public string JKTJPJ
        { get; set; }
        /// <summary> 
        /// 检查分类 
        /// </summary> 
        [SugarColumn(ColumnName = "JCFL", IsNullable = true, Length = 30)]
        public string JCFL
        { get; set; }
        /// <summary> 
        /// 康复措施 
        /// </summary> 
        [SugarColumn(ColumnName = "KFCS", IsNullable = true, Length = 30)]
        public string KFCS
        { get; set; }
        /// <summary> 
        /// 自知力 
        /// </summary> 
        [SugarColumn(ColumnName = "ZZL", IsNullable = true, Length = 30)]
        public string ZZL
        { get; set; }
        /// <summary> 
        /// 睡眠情况 
        /// </summary> 
        [SugarColumn(ColumnName = "XMQK", IsNullable = true, Length = 30)]
        public string XMQK
        { get; set; }
        /// <summary> 
        /// 饮食情况 
        /// </summary> 
        [SugarColumn(ColumnName = "YSQK", IsNullable = true, Length = 30)]
        public string YSQK
        { get; set; }
        /// <summary> 
        /// 预约时间 
        /// </summary> 
        [SugarColumn(ColumnName = "YYSJ", IsNullable = true)]
        public DateTime YYSJ
        { get; set; }
        /// <summary> 
        /// 是否统计 
        /// </summary> 
        [SugarColumn(ColumnName = "ISTJ", IsNullable = true)]
        public int ISTJ
        { get; set; }
        /// <summary> 
        /// SYS_YSGH 
        /// </summary> 
        [SugarColumn(ColumnName = "SYS_YSGH", IsNullable = true, Length = 50)]
        public string SYS_YSGH
        { get; set; }
        /// <summary> 
        /// 辅助检查眼底异常情况 
        /// </summary> 
        [SugarColumn(ColumnName = "YDYC", IsNullable = true, Length = 100)]
        public string YDYC
        { get; set; }
        /// <summary> 
        /// 辅助检查心电图异常情况 
        /// </summary> 
        [SugarColumn(ColumnName = "XDTYC", IsNullable = true, Length = 1000)]
        public string XDTYC
        { get; set; }
        /// <summary> 
        /// 辅助检查胸部X线片异常情况 
        /// </summary> 
        [SugarColumn(ColumnName = "XXYC", IsNullable = true, Length = 512)]
        public string XXYC
        { get; set; }
        /// <summary> 
        /// 辅助检查宫颈涂片异常情况 
        /// </summary> 
        [SugarColumn(ColumnName = "GJTPYC", IsNullable = true, Length = 100)]
        public string GJTPYC
        { get; set; }
        /// <summary> 
        /// 症状 
        /// </summary> 
        [SugarColumn(ColumnName = "ZZ2", IsNullable = true, Length = 100)]
        public string ZZ2
        { get; set; }
        /// <summary> 
        /// 其他症状 
        /// </summary> 
        [SugarColumn(ColumnName = "ZZ2QT", IsNullable = true, Length = 200)]
        public string ZZ2QT
        { get; set; }
        /// <summary> 
        /// 生活方式饮食习惯 
        /// </summary> 
        [SugarColumn(ColumnName = "YSXG2", IsNullable = true, Length = 50)]
        public string YSXG2
        { get; set; }
        /// <summary> 
        /// 生活方式饮酒种类 
        /// </summary> 
        [SugarColumn(ColumnName = "YJZL2", IsNullable = true, Length = 50)]
        public string YJZL2
        { get; set; }
        /// <summary> 
        /// 生活方式其他饮酒种类 
        /// </summary> 
        [SugarColumn(ColumnName = "YJZL2QT", IsNullable = true, Length = 100)]
        public string YJZL2QT
        { get; set; }
        /// <summary> 
        /// 查体乳腺 
        /// </summary> 
        [SugarColumn(ColumnName = "RX2", IsNullable = true, Length = 50)]
        public string RX2
        { get; set; }
        /// <summary> 
        /// 查体乳腺其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "RX2QT", IsNullable = true, Length = 100)]
        public string RX2QT
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_脑血管疾病情况 
        /// </summary> 
        [SugarColumn(ColumnName = "NXGJB2", IsNullable = true, Length = 50)]
        public string NXGJB2
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_脑血管疾病其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "NXGJB2QT", IsNullable = true, Length = 256)]
        public string NXGJB2QT
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_肾脏疾病情况 
        /// </summary> 
        [SugarColumn(ColumnName = "SZJB2", IsNullable = true, Length = 50)]
        public string SZJB2
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_肾脏疾病其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "SZJB2QT", IsNullable = true, Length = 50)]
        public string SZJB2QT
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_心脏疾病情况 
        /// </summary> 
        [SugarColumn(ColumnName = "XZJB2", IsNullable = true, Length = 50)]
        public string XZJB2
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_心脏疾病其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "XZJB2QT", IsNullable = true, Length = 256)]
        public string XZJB2QT
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_血管疾病情况 
        /// </summary> 
        [SugarColumn(ColumnName = "XGJB2", IsNullable = true, Length = 50)]
        public string XGJB2
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_血管疾病其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "XGJB2QT", IsNullable = true, Length = 50)]
        public string XGJB2QT
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_眼部疾病情况 
        /// </summary> 
        [SugarColumn(ColumnName = "YBJB2", IsNullable = true, Length = 50)]
        public string YBJB2
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_眼部疾病其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "YBJB2QT", IsNullable = true, Length = 256)]
        public string YBJB2QT
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_神经系统疾病情况 
        /// </summary> 
        [SugarColumn(ColumnName = "SJXT2", IsNullable = true, Length = 50)]
        public string SJXT2
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_神经系统疾病其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "SJXT2QT", IsNullable = true, Length = 50)]
        public string SJXT2QT
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_其他系统疾病情况 
        /// </summary> 
        [SugarColumn(ColumnName = "QTXT2", IsNullable = true, Length = 50)]
        public string QTXT2
        { get; set; }
        /// <summary> 
        /// 现存主要健康问题_其他疾病其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "QTXT2QT", IsNullable = true, Length = 200)]
        public string QTXT2QT
        { get; set; }
        /// <summary> 
        /// 健康评价其他情况 
        /// </summary> 
        [SugarColumn(ColumnName = "JKPJ2QT", IsNullable = true, Length = 5000)]
        public string JKPJ2QT
        { get; set; }
        /// <summary> 
        /// 健康指导情况 
        /// </summary> 
        [SugarColumn(ColumnName = "JKZD2", IsNullable = true, Length = 500)]
        public string JKZD2
        { get; set; }
        /// <summary> 
        /// 危险因数控制 
        /// </summary> 
        [SugarColumn(ColumnName = "WXYSKZ2", IsNullable = true, Length = 50)]
        public string WXYSKZ2
        { get; set; }
        /// <summary> 
        /// 废弃 
        /// </summary> 
        [SugarColumn(ColumnName = "JTZ", IsNullable = true, Length = 50)]
        public string JTZ
        { get; set; }
        /// <summary> 
        /// 建议接种疫苗 
        /// </summary> 
        [SugarColumn(ColumnName = "JYJZYM", IsNullable = true, Length = 500)]
        public string JYJZYM
        { get; set; }
        /// <summary> 
        /// 其他危险因素控制 
        /// </summary> 
        [SugarColumn(ColumnName = "QTWXYSKZ", IsNullable = true, Length = 1000)]
        public string QTWXYSKZ
        { get; set; }
        /// <summary> 
        /// 体检无异常说明 
        /// </summary> 
        [SugarColumn(ColumnName = "TJWYC", IsNullable = true, Length = 500)]
        public string TJWYC
        { get; set; }
        /// <summary> 
        /// B超其他 
        /// </summary> 
        [SugarColumn(ColumnName = "BCQT", IsNullable = true, Length = 1024)]
        public string BCQT
        { get; set; }
        /// <summary> 
        /// 体检项目评分 
        /// </summary> 
        [SugarColumn(ColumnName = "TJXMPF", IsNullable = true, Length = 5)]
        public string TJXMPF
        { get; set; }
        /// <summary> 
        /// 是否合格体检（1:是,0:否） 
        /// </summary> 
        [SugarColumn(ColumnName = "SFHGTJ", IsNullable = true, Length = 1)]
        public string SFHGTJ
        { get; set; }
        /// <summary> 
        /// 最后修改人 
        /// </summary> 
        [SugarColumn(ColumnName = "vc_LastEditMan", IsNullable = true, Length = 50)]
        public string vc_LastEditMan
        { get; set; }
        /// <summary> 
        /// 最后修改日期 
        /// </summary> 
        [SugarColumn(ColumnName = "D_LastDateTime", IsNullable = true)]
        public DateTime D_LastDateTime
        { get; set; }
        /// <summary> 
        /// 老年人认知功能评分 
        /// </summary> 
        [SugarColumn(ColumnName = "LNRRZGN_PF", IsNullable = true)]
        public decimal LNRRZGN_PF
        { get; set; }
        /// <summary> 
        /// 老年人抑郁评分 
        /// </summary> 
        [SugarColumn(ColumnName = "LNRQGZD_PF", IsNullable = true)]
        public decimal LNRQGZD_PF
        { get; set; }
        /// <summary> 
        /// 粉尘防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "FCFFCS_QT", IsNullable = true, Length = 50)]
        public string FCFFCS_QT
        { get; set; }
        /// <summary> 
        /// 放射物质防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "SXFFCS_QT", IsNullable = true, Length = 50)]
        public string SXFFCS_QT
        { get; set; }
        /// <summary> 
        /// 物理因素防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "WLFFCS_QT", IsNullable = true, Length = 50)]
        public string WLFFCS_QT
        { get; set; }
        /// <summary> 
        /// 化学物质防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "HXPFFCS_QT", IsNullable = true, Length = 50)]
        public string HXPFFCS_QT
        { get; set; }
        /// <summary> 
        /// 其他防护措施 
        /// </summary> 
        [SugarColumn(ColumnName = "QTFFCS_QT", IsNullable = true, Length = 50)]
        public string QTFFCS_QT
        { get; set; }
        /// <summary> 
        /// 皮肤其他 
        /// </summary> 
        [SugarColumn(ColumnName = "PF_QT", IsNullable = true, Length = 50)]
        public string PF_QT
        { get; set; }
        /// <summary> 
        /// 巩膜其他 
        /// </summary> 
        [SugarColumn(ColumnName = "GM_QT", IsNullable = true, Length = 50)]
        public string GM_QT
        { get; set; }
        /// <summary> 
        /// 淋巴结其他 
        /// </summary> 
        [SugarColumn(ColumnName = "LBJ_QT", IsNullable = true, Length = 50)]
        public string LBJ_QT
        { get; set; }
        /// <summary> 
        /// 呼吸音异常 
        /// </summary> 
        [SugarColumn(ColumnName = "HXY_QT", IsNullable = true, Length = 50)]
        public string HXY_QT
        { get; set; }
        /// <summary> 
        /// 罗音其他 
        /// </summary> 
        [SugarColumn(ColumnName = "LY_QT", IsNullable = true, Length = 50)]
        public string LY_QT
        { get; set; }
        /// <summary> 
        /// 杂音其他 
        /// </summary> 
        [SugarColumn(ColumnName = "ZY_QT", IsNullable = true, Length = 50)]
        public string ZY_QT
        { get; set; }
        /// <summary> 
        /// 压痛其他 
        /// </summary> 
        [SugarColumn(ColumnName = "YT_QT", IsNullable = true, Length = 50)]
        public string YT_QT
        { get; set; }
        /// <summary> 
        /// 包块其他 
        /// </summary> 
        [SugarColumn(ColumnName = "BK_QT", IsNullable = true, Length = 50)]
        public string BK_QT
        { get; set; }
        /// <summary> 
        /// 肝大其他 
        /// </summary> 
        [SugarColumn(ColumnName = "GD_QT", IsNullable = true, Length = 50)]
        public string GD_QT
        { get; set; }
        /// <summary> 
        /// 脾大其他 
        /// </summary> 
        [SugarColumn(ColumnName = "PD_QT", IsNullable = true, Length = 50)]
        public string PD_QT
        { get; set; }
        /// <summary> 
        /// 移动性浊音其他 
        /// </summary> 
        [SugarColumn(ColumnName = "YDXZY_QT", IsNullable = true, Length = 50)]
        public string YDXZY_QT
        { get; set; }
        /// <summary> 
        /// 肛门指诊其他 
        /// </summary> 
        [SugarColumn(ColumnName = "GMZZ_QT", IsNullable = true, Length = 50)]
        public string GMZZ_QT
        { get; set; }
        /// <summary> 
        /// 外阴其他 
        /// </summary> 
        [SugarColumn(ColumnName = "WY_QT", IsNullable = true, Length = 50)]
        public string WY_QT
        { get; set; }
        /// <summary> 
        /// 阴道其他 
        /// </summary> 
        [SugarColumn(ColumnName = "YD_QT", IsNullable = true, Length = 50)]
        public string YD_QT
        { get; set; }
        /// <summary> 
        /// 宫颈其他 
        /// </summary> 
        [SugarColumn(ColumnName = "GJ_QT", IsNullable = true, Length = 50)]
        public string GJ_QT
        { get; set; }
        /// <summary> 
        /// 宫体其他 
        /// </summary> 
        [SugarColumn(ColumnName = "GT_QT", IsNullable = true, Length = 50)]
        public string GT_QT
        { get; set; }
        /// <summary> 
        /// 附件其他 
        /// </summary> 
        [SugarColumn(ColumnName = "FJ_QT", IsNullable = true, Length = 50)]
        public string FJ_QT
        { get; set; }
        /// <summary> 
        /// 齿列2 
        /// </summary> 
        [SugarColumn(ColumnName = "CL2", IsNullable = true, Length = 50)]
        public string CL2
        { get; set; }
        /// <summary> 
        /// 体检异常评价2 
        /// </summary> 
        [SugarColumn(ColumnName = "JKPJ2QT2", IsNullable = true, Length = 1024)]
        public string JKPJ2QT2
        { get; set; }
        /// <summary> 
        /// 体检异常评价3 
        /// </summary> 
        [SugarColumn(ColumnName = "JKPJ2QT3", IsNullable = true, Length = 1024)]
        public string JKPJ2QT3
        { get; set; }
        /// <summary> 
        /// 体检异常评价4 
        /// </summary> 
        [SugarColumn(ColumnName = "JKPJ2QT4", IsNullable = true, Length = 1024)]
        public string JKPJ2QT4
        { get; set; }
        /// <summary> 
        /// 备注 
        /// </summary> 
        [SugarColumn(ColumnName = "TJBZ", IsNullable = true, Length = 400)]
        public string TJBZ
        { get; set; }
        /// <summary> 
        /// 体检编号 
        /// </summary> 
        [SugarColumn(ColumnName = "GUID", IsNullable = true, Length = 36)]
        public string GUID
        { get; set; }
        /// <summary> 
        /// 中性粒细胞数目 
        /// </summary> 
        [SugarColumn(ColumnName = "ZXLXBS", IsNullable = true, Length = 8)]
        public string ZXLXBS
        { get; set; }
        /// <summary> 
        /// 中间细胞数目 
        /// </summary> 
        [SugarColumn(ColumnName = "ZJXBS", IsNullable = true, Length = 8)]
        public string ZJXBS
        { get; set; }
        /// <summary> 
        /// 淋巴细胞数目 
        /// </summary> 
        [SugarColumn(ColumnName = "LBXBS", IsNullable = true, Length = 8)]
        public string LBXBS
        { get; set; }
        /// <summary> 
        /// B超其它 
        /// </summary> 
        [SugarColumn(ColumnName = "BCQIT", IsNullable = true, Length = 30)]
        public string BCQIT
        { get; set; }
        /// <summary> 
        /// B超其它说明 
        /// </summary> 
        [SugarColumn(ColumnName = "BCQITA", IsNullable = true, Length = 500)]
        public string BCQITA
        { get; set; }
        /// <summary> 
        /// 体重_数据来源 1:手工 2:设备 
        /// </summary> 
        [SugarColumn(ColumnName = "TZ_SJLY", IsNullable = true)]
        public int TZ_SJLY
        { get; set; }
        /// <summary> 
        /// 血糖_数据来源 1:手工 2:设备 
        /// </summary> 
        [SugarColumn(ColumnName = "XT_SJLY", IsNullable = true)]
        public int XT_SJLY
        { get; set; }
        /// <summary> 
        /// 体温_数据来源 1:手工 2:设备 
        /// </summary> 
        [SugarColumn(ColumnName = "TW_SJLY", IsNullable = true)]
        public int TW_SJLY
        { get; set; }
        /// <summary> 
        /// 抑郁评估记录（0,1,0） 
        /// </summary> 
        [SugarColumn(ColumnName = "YYPGJL", IsNullable = true, Length = 64)]
        public string YYPGJL
        { get; set; }
        /// <summary> 
        /// 是否筛查白内障  0 否  1 是 
        /// </summary> 
        [SugarColumn(ColumnName = "SFSCBNZ", IsNullable = true)]
        public int SFSCBNZ
        { get; set; }
    }
}
