using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Core.Model
{
    interface IDataRepository
    {
    }

    /// <summary>
    /// 平台仓储接口
    /// </summary>
    interface IDataRepository<TEntity> : IDataRepository where TEntity : class
    {

        /// <summary>
        /// 仓储自定义方法
        /// </summary>
        /// <returns></returns>
        List<TEntity> CommQuery();

        List<TEntity> GetAllList();

        ISugarQueryable<TEntity> GetAll();


        /// <summary>
        /// 根据条件分页查询
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        List<TEntity> GetPageList(int pageIndex, int pageSize, ref int Total, List<Expression<Func<TEntity, bool>>> predicateList, string sort, bool isSort = true);


        #region 添加
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="T"></param>
        TEntity Insert(TEntity T);

        bool Insert(string strSql, SugarParameter[] parameters = null);

        #endregion

        #region 更新
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="columns">更新列</param>
        /// <param name="predicate">条件</param>
        void Update(Expression<Func<TEntity, bool>> columns, Expression<Func<TEntity, bool>> predicate);

        int Update(TEntity T);

        int Update(List<TEntity> list);

        #endregion

        #region 删除
        /// <summary>
        /// 删除数据 根据主键ID
        /// </summary>
        /// <param name="ID"></param>
        int Delete(object ID);

        /// <summary>
        /// 删除数据 根据条件
        /// </summary>
        /// <param name="ID"></param>
        int Delete(Expression<Func<TEntity, bool>> predicate);


        /// <summary>
        /// 删除数据 根据实体
        /// </summary>
        /// <param name="ID"></param>
        int Delete(List<TEntity> list);


        /// <summary>
        /// 删除数据 根据list集合
        /// </summary>
        /// <param name="ID"></param>
        int Delete(TEntity T);

        #endregion
    }
}
