using Pro.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Pro.Core.DAL
{
    public interface IBaseService
    {
        /// <summary>
        /// 获取所有学生信息
        /// </summary>
        /// <returns></returns>
        List<Student> Getlist();

        /// <summary>
        /// 分页查询学生信息
        /// </summary>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每页系那是条数</param>
        /// <param name="sort">排序字段及方式(例：s_id-desc)</param>
        /// <param name="Total">总条数</param>
        /// <param name="parmList">条件集合</param>
        /// <param name="isSort">是否排序</param>
        /// <returns></returns>
        List<Student> GetPageList(int pageIndex, int pageSize, string sort, ref int total, List<Expression<Func<Student, bool>>> parmList, bool isSort = true);
    }
}
