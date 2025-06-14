using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Pro.Core.Model
{
    public class DBContext : SugarUnitOfWork
    {
        public DbSet<Student> Student { get; set; }

        /// <summary>
        /// 自定义仓储
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        public class DbSet<TEntity> : SimpleClient<TEntity> where TEntity : class, new()
        {
            /// <summary>
            /// 仓储自定义方法
            /// </summary>
            /// <returns></returns>
            public List<TEntity> CommQuery()
            {
                return base.Context.Queryable<TEntity>().ToList();
            }

            public List<TEntity> GetAllList()
            {
                return base.Context.Queryable<TEntity>().ToList();
            }

            public ISugarQueryable<TEntity> GetAll()
            {
                return base.Context.Queryable<TEntity>();
            }

            /// <summary>
            /// 根据条件分页查询
            /// </summary>
            /// <param name="predicate"></param>
            /// <returns></returns>
            public List<TEntity> GetPageList(int pageIndex, int pageSize, ref int Total, List<Expression<Func<TEntity, bool>>> predicateList, string sort, bool isSort = true)
            {
                var query = base.Context.Queryable<TEntity>();
                if (predicateList != null && predicateList.Count > 0)
                {
                    foreach (var predicate in predicateList)
                    {
                        query = query.Where(predicate);
                    }
                }

                if (isSort && !string.IsNullOrEmpty(sort) && sort.Contains('-'))
                {
                    string sortExpression = sort.Split('-')[0];
                    string sortDirection = sort.Split('-')[1];

                    query = query.OrderBy(sortExpression + " " + sortDirection);
                }

                return query.ToPageList(pageIndex, pageSize, ref Total);
            }


            #region 添加
            /// <summary>
            /// 添加数据
            /// </summary>
            /// <param name="T"></param>
            public TEntity Insert(TEntity T)
            {
                int i = base.Context.Insertable(T).ExecuteCommand();
                if (i > 0)
                {
                    return T;
                }
                return null;
            }


            public bool Insert(string strSql, SugarParameter[] parameters = null)
            {
                return base.Context.Ado.ExecuteCommand(strSql, parameters) > 0;
            }
            #endregion

            #region 更新
            /// <summary>
            /// 更新数据
            /// </summary>
            /// <param name="columns">更新列</param>
            /// <param name="predicate">条件</param>
            public void Update(Expression<Func<TEntity, bool>> columns, Expression<Func<TEntity, bool>> predicate)
            {
                base.Context.Updateable<TEntity>().SetColumns(columns).Where(predicate).ExecuteCommand();
            }

            public int Update(TEntity T)
            {
                return base.Context.Updateable(T).ExecuteCommand();
            }

            public int Update(List<TEntity> list)
            {
                return base.Context.Updateable(list).ExecuteCommand();
            }
            #endregion

            #region 删除
            /// <summary>
            /// 删除数据 根据主键ID
            /// </summary>
            /// <param name="ID"></param>
            public int Delete(object ID)
            {
                return base.Context.Deleteable<TEntity>().In(ID).ExecuteCommand();
            }

            /// <summary>
            /// 删除数据 根据条件
            /// </summary>
            /// <param name="ID"></param>
            public int Delete(Expression<Func<TEntity, bool>> predicate)
            {
                return base.Context.Deleteable<TEntity>().Where(predicate).ExecuteCommand();
            }

            /// <summary>
            /// 删除数据 根据实体
            /// </summary>
            /// <param name="ID"></param>
            public int Delete(List<TEntity> list)
            {
                return base.Context.Deleteable<TEntity>().Where(list).ExecuteCommand();
            }

            /// <summary>
            /// 删除数据 根据list集合
            /// </summary>
            /// <param name="ID"></param>
            public int Delete(TEntity T)
            {
                return base.Context.Deleteable<TEntity>().Where(T).ExecuteCommand();
            }
            #endregion

        }
    }
}
