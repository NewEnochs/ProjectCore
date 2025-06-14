using System.ComponentModel;
using SqlSugar;
using System;

namespace Pro.Core.Model
{
    /// <summary>
    /// 菜单表
    ///</summary>
    [SugarTable("SYS_BS_MENU")]
    public class SYS_BS_MENU
    {
     
        /// <summary>
        /// 
        ///</summary>
        [SugarColumn(ColumnName="ID" ,IsPrimaryKey = true) ]
        [DisplayName("")]
        public int ID  { get; set;  } 
     
        /// <summary>
        /// 上级菜单ID
        ///</summary>
        [SugarColumn(ColumnName="PID" ) ]
        [DisplayName("上级菜单ID")]
        public int PID  { get; set;  } 
     
        /// <summary>
        /// 上级菜单集合
        ///</summary>
        [SugarColumn(ColumnName="PIDS" ) ]
        [DisplayName("上级菜单集合")]
        public string? PIDS  { get; set;  } 
     
        /// <summary>
        /// 菜单名称
        ///</summary>
        [SugarColumn(ColumnName="NAME" ) ]
        [DisplayName("菜单名称")]
        public string? NAME  { get; set;  } 
     
        /// <summary>
        /// 菜单编码
        ///</summary>
        [SugarColumn(ColumnName="CODE" ) ]
        [DisplayName("菜单编码")]
        public string? CODE  { get; set;  } 
     
        /// <summary>
        /// 菜单类型（字典 0目录 1菜单 2按钮）
        ///</summary>
        [SugarColumn(ColumnName="TYPE" ) ]
        [DisplayName("菜单类型（字典 0目录 1菜单 2按钮）")]
        public int TYPE  { get; set;  } 
     
        /// <summary>
        /// 图标
        ///</summary>
        [SugarColumn(ColumnName="ICON" ) ]
        [DisplayName("图标")]
        public string? ICON  { get; set;  } 
     
        /// <summary>
        /// 路由地址
        ///</summary>
        [SugarColumn(ColumnName="ROUTER" ) ]
        [DisplayName("路由地址")]
        public string? ROUTER  { get; set;  } 
     
        /// <summary>
        /// 组件地址
        ///</summary>
        [SugarColumn(ColumnName="COMPONENT" ) ]
        [DisplayName("组件地址")]
        public string? COMPONENT  { get; set;  } 
     
        /// <summary>
        /// 
        ///</summary>
        [SugarColumn(ColumnName="PERMISSION" ) ]
        [DisplayName("")]
        public string? PERMISSION  { get; set;  } 
     
        /// <summary>
        /// 应用分类（应用编码）
        ///</summary>
        [SugarColumn(ColumnName="APPLICATION" ) ]
        [DisplayName("应用分类（应用编码）")]
        public string? APPLICATION  { get; set;  } 
     
        /// <summary>
        /// 打开方式（字典 0无 1组件 2内链 3外链）
        ///</summary>
        [SugarColumn(ColumnName="OPENTYPE" ) ]
        [DisplayName("打开方式（字典 0无 1组件 2内链 3外链）")]
        public int OPENTYPE  { get; set;  } 
     
        /// <summary>
        /// 是否可见（Y-是，N-否）
        ///</summary>
        [SugarColumn(ColumnName="VISIBLE" ) ]
        [DisplayName("是否可见（Y-是，N-否）")]
        public string? VISIBLE  { get; set;  } 
     
        /// <summary>
        /// 内链地址
        ///</summary>
        [SugarColumn(ColumnName="LINK" ) ]
        [DisplayName("内链地址")]
        public string? LINK  { get; set;  } 
     
        /// <summary>
        /// 重定向地址
        ///</summary>
        [SugarColumn(ColumnName="REDIRECT" ) ]
        [DisplayName("重定向地址")]
        public string? REDIRECT  { get; set;  } 
     
        /// <summary>
        /// 权重（字典 1系统权重 2业务权重 3 管理权重）
        ///</summary>
        [SugarColumn(ColumnName="WEIGHT" ) ]
        [DisplayName("权重（字典 1系统权重 2业务权重 3 管理权重）")]
        public int WEIGHT  { get; set;  } 
     
        /// <summary>
        /// 排序
        ///</summary>
        [SugarColumn(ColumnName="SORT" ) ]
        [DisplayName("排序")]
        public int SORT  { get; set;  } 
     
        /// <summary>
        /// 备注
        ///</summary>
        [SugarColumn(ColumnName="REMARK" ) ]
        [DisplayName("备注")]
        public string? REMARK  { get; set;  } 
     
        /// <summary>
        /// 状态
        ///</summary>
        [SugarColumn(ColumnName="STATUS" ) ]
        [DisplayName("状态")]
        public int STATUS  { get; set;  } 
     
        /// <summary>
        /// 
        ///</summary>
        [SugarColumn(ColumnName="CREATEDTIME" ) ]
        [DisplayName("")]
        public DateTime? CREATEDTIME  { get; set;  } 
     
        /// <summary>
        /// 
        ///</summary>
        [SugarColumn(ColumnName="UPDATEDTIME" ) ]
        [DisplayName("")]
        public DateTime? UPDATEDTIME  { get; set;  } 
     
        /// <summary>
        /// 
        ///</summary>
        [SugarColumn(ColumnName="CREATEDUSERID" ) ]
        [DisplayName("")]
        public int? CREATEDUSERID  { get; set;  } 
     
        /// <summary>
        /// 
        ///</summary>
        [SugarColumn(ColumnName="CREATEDUSERNAME" ) ]
        [DisplayName("")]
        public string? CREATEDUSERNAME  { get; set;  } 
     
        /// <summary>
        /// 
        ///</summary>
        [SugarColumn(ColumnName="UPDATEDUSERID" ) ]
        [DisplayName("")]
        public int? UPDATEDUSERID  { get; set;  } 
     
        /// <summary>
        /// 
        ///</summary>
        [SugarColumn(ColumnName="UPDATEDUSERNAME" ) ]
        [DisplayName("")]
        public string? UPDATEDUSERNAME  { get; set;  } 
     
        /// <summary>
        /// 
        ///</summary>
        [SugarColumn(ColumnName="new_id" ) ]
        [DisplayName("")]
        public int? New_id  { get; set;  } 
     
        /// <summary>
        /// 菜单权限级别（1：镇级 2：县级 3：市级）
        ///</summary>
        [SugarColumn(ColumnName="CDQXJB" ) ]
        [DisplayName("菜单权限级别（1：镇级 2：县级 3：市级）")]
        public int? CDQXJB  { get; set;  }

        /// <summary>
        /// 免刷名单
        ///</summary>
        [SugarColumn(ColumnName = "MSMD")]
        [DisplayName("免刷名单（0：否 1：是）")]
        public int? MSMD { get; set; }
    }
    
}