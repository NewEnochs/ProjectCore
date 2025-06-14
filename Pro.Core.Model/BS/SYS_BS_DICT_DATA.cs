using System;
using SqlSugar;
using System.ComponentModel;

namespace Pro.Core.Model
{
    /// <summary>
    /// 字典值表
    /// </summary>
    [SugarTable("SYS_BS_DICT_DATA")]
    public class SYS_BS_DICT_DATA : DEntityBase
    {
        /// <summary>
        /// 字典类型Id
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }

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
        /// 机构ID
        /// </summary>
        public int Orgid { get; set; }

        /// <summary>
        /// 状态（字典 0正常 1停用 2删除）
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 所属类型
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public SYS_BS_DICT_TYPE SysDictType { get; set; }
    }
}
