using Microsoft.AspNetCore.Mvc;
using TCC_CoreApi.Model;
using TCC_CoreApi.Common.Tool;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using TCC_CoreApi.Model.entity;
using System.Linq;

namespace TCC_WebAPI.Controllers
{
    [Route("api/SinglePool")]
    [ApiController]
    public class SinglePoolController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public SinglePoolController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }


        #region 池子待办已办
        /// <summary>
        /// 新增待办
        /// </summary>
        /// <param name="items">新增待办明细</param>
        /// <returns></returns>
        [HttpPost("FPInboxForCreate")]
        public async Task<string> FPInboxForCreate([FromBody] List<LandrayCashierTaskFpInbox> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                string CasierClaimName = "";
                if (items.Count == 0)
                {
                    resultMessage.Message = "添加项为空!";
                    resultMessage.Result = 1;
                }
                else
                {
                    //Logger.Info("FPInboxForCreate-" + items.ToJson());
                    foreach (var item in items)
                    {

                        var daibantodos = _dbContext.Landray_CashierTask_FP_Inbox.Where(t => t.TaskId == item.TaskId).Where(t => t.SName == "财务接单审核").Where(t => t.Flag == 1).ToList();
                        if(daibantodos.Count > 0)
                        {
                            foreach (var daibantodo in daibantodos)
                            {
                                CasierClaimName = string.IsNullOrEmpty(daibantodo.CasierClaim) ? "" : daibantodo.CasierClaim;
                            }
                        }
                        item.CasierClaim = CasierClaimName;
                        item.Flag = 0;
                        _dbContext.Landray_CashierTask_FP_Inbox.Add(item);
                        await _dbContext.SaveChangesAsync();
                    }
                    resultMessage.Message = "添加成功！";
                    resultMessage.Result = 0;
                }
            }
            catch (System.Exception ex)
            {
                Logger.Info("SinglePoolController-新增待办明细(FPInboxForCreate)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }

        /// <summary>
        /// 修改待办（变为已办）
        /// </summary>
        /// <param name="items">修改已办明细(Flag 0:流程中,1:已完成 ,2:已撤销)</param>
        /// <returns></returns>
        [HttpPost("FPInboxForModefied")]
        public async Task<string> FPInboxForModefied(List<LandrayCashierTaskFpInbox> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                string warnmessage = "";
                string errmessage = "";
                string message = "";
                int resultcode = 0;
                string CasierClaimName = "";

                if (items.Count == 0)
                {
                    errmessage = "修改项为空!";
                    resultcode = 1;
                }
                else
                {
                    var daibantodos = _dbContext.Landray_CashierTask_FP_Inbox.Where(t => t.TaskId == items[0].TaskId).Where(t => t.SName == "财务接单审核").Where(t => t.Flag == 1).ToList();
                    if (daibantodos.Count > 0)
                    {
                        foreach (var daibantodo in daibantodos)
                        {
                            CasierClaimName = string.IsNullOrEmpty(daibantodo.CasierClaim) ? "" : daibantodo.CasierClaim;
                        }
                    }

                    foreach (var item in items)
                    {
                        var todos = _dbContext.Landray_CashierTask_FP_Inbox.Where(t => t.TaskId == item.TaskId).Where(t => t.SName == item.SName).Where(t => t.TUser == item.TUser).ToList();
                        if (todos.Count == 0)
                        {
                            warnmessage += "【" + item.TaskId + "】,";//修改项在数据库中未找到!
                        }
                        else
                        {
                            foreach (var todo in todos)
                            {
                                todo.TEndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                todo.CasierClaim = string.IsNullOrEmpty(item.CasierClaim) ? CasierClaimName : item.CasierClaim;
                                todo.AuditName = item.AuditName;
                                todo.Flag = item.Flag;

                                _dbContext.Landray_CashierTask_FP_Inbox.Update(todo);
                                await _dbContext.SaveChangesAsync();
                            }
                            message += "【" + item.BillCode + "】,";//修改成功
                            resultcode = 0;
                        }

                        #region 删除数据
                        var DtoDeleteEntitys = _dbContext.Landray_CashierTask_FP_Inbox.Where(t => t.TaskId == item.TaskId).Where(t => t.SName == item.SName).Where(t => t.TUser != item.TUser).ToList();
                        if (todos.Count > 0)
                        {
                            foreach (var DtoDeleteEntity in DtoDeleteEntitys)
                            {
                                _dbContext.Landray_CashierTask_FP_Inbox.Remove(DtoDeleteEntity);
                                await _dbContext.SaveChangesAsync();
                            }
                        }
                        #endregion
                    }

                }
                warnmessage = warnmessage == "" ? "" : warnmessage.Substring(0, warnmessage.Length - 1) + "修改项在数据库中未找到! ";
                message = message == "" ? "" : message.Substring(0, message.Length - 1) + "修改成功";
                string alertmessage = warnmessage + message;
                resultMessage.Message = errmessage != "" ? errmessage : alertmessage;
                resultMessage.Result = resultcode;
            }
            catch (System.Exception ex)
            {
                Logger.Info("SinglePoolController-修改已办明细(FPInboxForModefied)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }

        #endregion
        /// <summary>
        /// 流程废弃
        /// </summary>
        /// <param name="fd_id">蓝凌主键fd_id</param>
        /// <returns></returns>
        [HttpPost("FPInboxForAborted")]
        public async Task<string> FPInboxForAborted(string fd_id)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                var todos = _dbContext.Landray_CashierTask_FP_Inbox.Where(t => t.TaskId == fd_id).ToList();
                if (todos.Count == 0)
                {
                    resultMessage.Message = "修改项为空!";
                    resultMessage.Result = 1;
                }
                else
                {
                    foreach (var todo in todos)
                    {
                        todo.Flag = 2;
                        _dbContext.Landray_CashierTask_FP_Inbox.Update(todo);
                        await _dbContext.SaveChangesAsync();
                    }
                    resultMessage.Message = "修改成功!";
                    resultMessage.Result = 0;
                }
            }
            catch (System.Exception ex)
            {
                Logger.Info("SinglePoolController-流程废弃(FPInboxForAborted)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }
    }
}
