using SqlSugar;
using System;

namespace Pro.Core.Model
{
    /// <summary>
    /// 系统_FTP目录
    ///</summary>
    [SugarTable("SYS_FTPSET")]
    public class SYS_FTPSET
    {
        /// <summary>
        /// 表名称 
        ///</summary>
        [SugarColumn(ColumnName = "TABLENAME", IsPrimaryKey = true)]
        public string TABLENAME { get; set; }
        /// <summary>
        /// FTP账号 
        ///</summary>
        [SugarColumn(ColumnName = "FTPUSER")]
        public string FTPUSER { get; set; }
        /// <summary>
        /// FTP密码 
        ///</summary>
        [SugarColumn(ColumnName = "FTPPASSWORD")]
        public string FTPPASSWORD { get; set; }
        /// <summary>
        /// 创建时间 
        ///</summary>
        [SugarColumn(ColumnName = "CJSJ")]
        public DateTime? CJSJ { get; set; }
        /// <summary>
        /// 更新时间 
        ///</summary>
        [SugarColumn(ColumnName = "GXSJ")]
        public DateTime? GXSJ { get; set; }
        /// <summary>
        /// 备注 
        ///</summary>
        [SugarColumn(ColumnName = "REMARK")]
        public string REMARK { get; set; }
        /// <summary>
        /// FTP地址 
        ///</summary>
        [SugarColumn(ColumnName = "FTPURL")]
        public string FTPURL { get; set; }

        [SugarColumn(IsIgnore = true)]
        public string Type { get; set; }
    }
}
