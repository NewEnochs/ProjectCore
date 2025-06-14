using System;
using SqlSugar;
using System.ComponentModel;

namespace Pro.Core.Model
{
    /// <summary>
    /// 自定义实体基类
    /// </summary>
    public abstract class DEntityBase 
    {
        /// <summary>
        /// 编号
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreatedTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public virtual DateTime UpdatedTime { get; set; }

        /// <summary>
        /// 创建者Id
        /// </summary>
        public virtual int? CreatedUserId { get; set; }

        /// <summary>
        /// 创建者名称
        /// </summary>
        public virtual string CreatedUserName { get; set; }

        /// <summary>
        /// 修改者Id
        /// </summary>
        public virtual int? UpdatedUserId { get; set; }

        /// <summary>
        /// 修改者名称
        /// </summary>
        public virtual string UpdatedUserName { get; set; }
        /// <summary>
        /// 设置默认值
        /// </summary>
        public void SetDefalut()
        {
            //if (Id == 0)
            //{
            //    CreatedUserName = Claims.Name;
            //    CreatedUserId = Claims.UserId;
            //    CreatedTime = DateTime.Now;
            //    UpdatedTime = DateTime.Now;
            //    UpdatedUserId = Claims.UserId;
            //    UpdatedUserName = Claims.Name;
            //}
            //else
            //{
            //    UpdatedTime = DateTime.Now;
            //    UpdatedUserId = Claims.UserId;
            //    UpdatedUserName = Claims.Name;

            //}
        }
    }
}
