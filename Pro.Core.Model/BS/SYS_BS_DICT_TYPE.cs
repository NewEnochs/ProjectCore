using System;
using SqlSugar;
using System.ComponentModel;

namespace Pro.Core.Model
{
    /// <summary>
    /// 字典类型表
    /// </summary>
    [SugarTable("SYS_BS_DICT_TYPE")]
    public class SYS_BS_DICT_TYPE : DEntityBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 状态（字典 0正常 1停用 2删除）
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 是否系统字典（0：非系统 1：系统字典）
        /// </summary>
        public int Issystem { get; set; }

    }
}
