using System;
using System.Collections.Generic;
using System.Text;

namespace Pro.Core.Model
{
    public class ColumnAttr
    {

    }

    /// <summary>
    /// 不更新列
    /// </summary>
    public class NoUpdateColumn : Attribute
    {
        public NoUpdateColumn() { }
    }

    /// <summary>
    /// 更新列
    /// </summary>
    public class UpdateColumn : Attribute
    {
        public UpdateColumn() { }
    }

    /// <summary>
    /// 导出属性
    /// </summary>
    public class ExportAttr : Attribute
    {
        public ExportAttr()
        {
        }
        public int SORT { get; set; }
    }
}
