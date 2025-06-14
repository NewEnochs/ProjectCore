using System;
using SqlSugar;
using System.ComponentModel;

namespace Pro.Core.Model
{
    /// <summary>
    /// 系统应用
    ///</summary>
    [SugarTable("SYS_BS_APP")]
    public class SYS_BS_APP
    {
        /// <summary>
        ///  ID
        ///</summary>
        [SugarColumn(ColumnName = "ID", IsPrimaryKey = true, IsIdentity = true)]
        [DisplayName("ID")]
        public int ID { get; set; }
        /// <summary>
        /// 应用名称 
        ///</summary>
        [SugarColumn(ColumnName = "NAME")]
        [DisplayName("应用名称")]
        public string NAME { get; set; }
        /// <summary>
        /// 应用编码 
        ///</summary>
        [SugarColumn(ColumnName = "CODE")]
        [DisplayName("应用编码")]
        public string CODE { get; set; }
        /// <summary>
        /// 是否默认激活（Y-是，N-否）,只能有一个系统默认激活 用户登录后默认展示此系统菜单 
        ///</summary>
        [SugarColumn(ColumnName = "ACTIVE")]
        [DisplayName("是否默认激活（Y-是，N-否）,只能有一个系统默认激活 用户登录后默认展示此系统菜单")]
        public string ACTIVE { get; set; }
        /// <summary>
        /// 状态（字典 0正常 1停用 2删除） 
        ///</summary>
        [SugarColumn(ColumnName = "STATUS")]
        [DisplayName("状态（字典 0正常 1停用 2删除）")]
        public int STATUS { get; set; }
        /// <summary>
        /// 排序 
        ///</summary>
        [SugarColumn(ColumnName = "SORT")]
        [DisplayName("排序")]
        public int SORT { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "CREATEDTIME")]
        [DisplayName("")]
        public DateTime? CREATEDTIME { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "UPDATEDTIME")]
        [DisplayName("")]
        public DateTime? UPDATEDTIME { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "CREATEDUSERID")]
        [DisplayName("")]
        public int? CREATEDUSERID { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "CREATEDUSERNAME")]
        [DisplayName("")]
        public string CREATEDUSERNAME { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "UPDATEDUSERID")]
        [DisplayName("")]
        public int? UPDATEDUSERID { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "UPDATEDUSERNAME")]
        [DisplayName("")]
        public string UPDATEDUSERNAME { get; set; }
        /// <summary>
        /// 路由 
        ///</summary>
        [SugarColumn(ColumnName = "ROUTER")]
        [DisplayName("路由")]
        public string ROUTER { get; set; }
        /// <summary>
        /// 路由 
        ///</summary>
        [SugarColumn(ColumnName = "TYPE")]
        [DisplayName("路由")]
        public int TYPE { get; set; }
    }
}
