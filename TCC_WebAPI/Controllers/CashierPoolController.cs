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
    [Route("api/CashierPool")]
    [ApiController]
    public class CashierPoolController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public CashierPoolController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }

        #region 出纳池子待办已办
        /// <summary>
        /// 出纳池子新增待办
        /// </summary>
        /// <param name="items">新增待办明细</param>
        /// <returns></returns>
        [HttpPost("CPInboxForCreate")]
        public async Task<string> CPInboxForCreate([FromBody] List<LandrayFinanceCashierConfirm> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                if (items.Count == 0)
                {
                    resultMessage.Message = "添加项为空!";
                    resultMessage.Result = 1;
                }
                else
                {
                    foreach (var item in items)
                    {
                        _dbContext.Landray_FinanceCashierConfirm.Add(item);
                        await _dbContext.SaveChangesAsync();
                    }
                    resultMessage.Message = "添加成功！";
                    resultMessage.Result = 0;
                }
            }
            catch (System.Exception ex)
            {
                Logger.Info("CashierPoolController-出纳池子新增待办(CPInboxForCreate)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }

        /// <summary>
        /// 出纳池子修改待办（变为已办）
        /// </summary>
        /// <param name="items">修改明细(IsVoucher:是否入账 ；ConfirmPayment：是否确认)</param>
        /// <returns></returns>
        [HttpPost("CPInboxForModefied")]
        public async Task<string> CPInboxForModefied(List<LandrayFinanceCashierConfirm> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                string warnmessage = "";
                string errmessage = "";
                string message = "";
                int resultcode = 0;
                if (items.Count == 0)
                {
                    errmessage = "修改项为空!";
                    resultcode = 1;
                }
                else
                {
                    foreach (var item in items)
                    {
                        var todos = _dbContext.Landray_FinanceCashierConfirm.Where(t => t.fd_id == item.fd_id).Where(t => t.PaymentMethodName == item.PaymentMethodName).ToList();
                        if (todos.Count == 0)
                        {
                            warnmessage += "【" + item.fd_id + "】,";//修改项在数据库中未找到!
                        }
                        else
                        {
                            foreach (var todo in todos)
                            {
                                _dbContext.Landray_FinanceCashierConfirm.Update(todo);
                                await _dbContext.SaveChangesAsync();
                            }
                            message += "【" + item.fd_id + "】,";//修改成功
                            resultcode = 0;
                        }
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
                Logger.Info("CashierPoolController-出纳池子修改待办（变为已办）(CPInboxForModefied)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }

        #endregion
    }
}
