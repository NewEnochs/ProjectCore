using Pro.Core.Common;
using Pro.Core.Model;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace Pro.Core.DAL
{
    public class StudentService : IBaseService
    {
        public ISugarUnitOfWork<DBContext> Context;
        public StudentService(ISugarUnitOfWork<DBContext> context)
        {
            this.Context = context;
        }

        /// <summary>
        /// 获取所有学生信息
        /// </summary>
        /// <returns></returns>
        public List<Student> Getlist()
        {
            using (var uow = Context.CreateContext())//带事务
            {
                var list = uow.Student.AsQueryable().ToList();
                return list;
            }
        }

        #region 分页查询
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
        public List<Student> GetPageList(int pageIndex, int pageSize, string sort, ref int total, List<Expression<Func<Student, bool>>> parmList, bool isSort = true)
        {
            using (var uow = Context.CreateContext())//带事务
            {
                var query = uow.Student.AsQueryable();
                if (parmList != null && parmList.Count > 0)
                {
                    foreach (var parm in parmList)
                    {
                        query = query.Where(parm);
                    }
                }
                if (isSort && !string.IsNullOrEmpty(sort) && sort.Contains('-'))
                {
                    string sortExpression = sort.Split('-')[0];
                    string sortDirection = sort.Split('-')[1];

                    query = query.OrderBy(sortExpression + " " + sortDirection);
                }

                var list = query.ToPageList(pageIndex, pageSize, ref total);
                return list;
            }
        }
        #endregion
    }
}
