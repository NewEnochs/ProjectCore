using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pro.Core.BLL;
using Pro.Core.DAL;
using Pro.Core.Model;
using Pro.Core.WebApi.Common;
using Pro.Core.Extension;
using SqlSugar;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Pro.Core.Common;
using static Pro.Core.Model.DBContext;
using NPOI.SS.Formula.Functions;

namespace Pro.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        BaseService<Student> stuDal;
        ISugarUnitOfWork<DBContext> Context;
        public StudentController(BaseService<Student> _stuDal, ISugarUnitOfWork<DBContext> context)
        {
            this.stuDal = _stuDal;
            this.Context = context;
        }

        /// <summary>
        /// 获取所有信息
        /// </summary>
        /// <returns></returns>
        [HttpPost("GetList")]
        public List<Student> GetList()
        {
            var list = stuDal.GetList();
            var data1 = stuDal.GetListByParm(c => c.s_loginName.Contains("z"));
            List<Expression<Func<Student, bool>>> parmList = new List<Expression<Func<Student, bool>>>();
            int total = 0;
            parmList.Add(c => c.s_loginName.Contains("z"));
            var pageList = stuDal.GetPageList(1, 12, ref total, parmList, "s_createDate-desc");
            return list;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetListByCondition")]
        public AjaxPager GetListByCondition(int page, int pageSize, string sortName, string searchs)
        {
            AjaxPager ajax = new AjaxPager();

            ajax.IsSuccess = false;
            ajax.Message = "查询失败,系统异常";
            try
            {
                #region 条件查询组合
                var searchData = !string.IsNullOrEmpty(searchs) ? JsonConvert.DeserializeObject<List<PropModel>>(searchs) : new List<PropModel>();

                //lamada表达式 条件数组
                List<Expression<Func<Student, bool>>> parmList = new List<Expression<Func<Student, bool>>>();
                new ExpressionSearch<Student>().GetSearch(searchData, parmList);
                #endregion

                int total = 0;
                using (var uow = Context.CreateContext())//带事务
                {
                    sortName = string.IsNullOrEmpty(sortName) ? "s_createDate-desc" : sortName;
                    var list = uow.Student.GetPageList(page, pageSize, ref total, parmList, sortName);

                    ajax.Rows = list;
                    ajax.Total = total;         //数据总条数
                    ajax.PageIndex = page; //当前页
                    ajax.PageSize = pageSize;   //每页显示条数
                    ajax.Sort = sortName;

                    ajax.IsSuccess = true;
                    ajax.Message = "查询成功";
                }
            }
            catch (Exception ex)
            {
                ajax.IsSuccess = false;
                ajax.Message = ex.Message;
            }
            return ajax;
        }



        #region UnitOfWOrk(工作单元)

        [HttpGet("Add")]
        public List<Student> AddStudent(Student student)
        {
            var db = DbBase.Db;
            using (var uow = Context.CreateContext())//带事务
            {
                try
                {
                    var list3 = uow.Student.GetList();//查询OrderItem

                    //也可以手动调用仓储
                    var orderItemDal = uow.GetMyRepository<DbSet<Student>>();
                    if (student == null)
                    {
                        orderItemDal.AsInsertable(new Student()
                        {
                            s_id = Guid.NewGuid(),
                            s_name = "薛天",
                            s_loginName = "xuetian",
                            s_address = "重庆",
                            s_age = 25,
                            s_phone = "18952369842",
                            s_passWord = "123456",
                            s_sex = (int)Gender.Male,
                            s_Grade_ID = new Guid("F48B722E-E8CF-4FD6-94DD-F4AAAEE936A2"),
                            s_createDate = DateTime.Now,
                            s_status = (int)SysStatus.Enable,
                            s_remark = "备注说明,能否添加呢"
                        }).ExecuteCommand();
                    }
                    else
                    {
                        orderItemDal.AsUpdateable(student);
                    }
                    uow.Commit();
                    return list3;
                }
                catch (Exception)
                {
                    uow.Dispose();
                    return null;
                }
            }
        }

        [HttpPost("UpdateAddress")]
        public bool Update(string address)
        {
            var db = DbBase.Db;
            using (var uow = Context.CreateContext())//带事务
            {
                var student1 = uow.Student.GetFirst(c => c.s_loginName == "zhangbo");
                Student student2 = uow.Student.GetById("02CA3F7B-ED8E-41C8-930E-6A2F3DD993B0");
                student1.s_address = address;
                uow.Student.Update(student1);
                return uow.Commit();

            }
        }
        #endregion

    }
}
