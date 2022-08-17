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
using static TCC_WebAPI.App_Code.PaymentPublicHelper;
using TCC_WebAPI.App_Code;

namespace TCC_WebAPI.Controllers
{
    [Route("api/BillInfoManage")]
    [ApiController]
    public class BillManageController : ControllerBase
    {
        private string BusinessConnectionString = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnectionZS");
        private string BusinessConnectionStringTest = ConfigManager.GetSectionValue("ConnectionStrings", "SqlServerConnection");

        private readonly ApiDBContent _dbContext;
        public BillManageController(ApiDBContent dbContext)
        {
            _dbContext = dbContext;
        }



        #region 票据台账
        /// <summary>
        /// 汇入票据台账
        /// </summary>
        /// <param name="items">发票明细（包含部分业务信息）</param>
        /// <param name="fd_exitsid">fd_id 用于筛选 删除已存在fd_id 的票据信息</param>
        /// <returns></returns>
        [HttpPost("BillInfoForCreate")]
        public async Task<string> CreateKBillInfo([FromBody] List<LandrayBillsManagement> items,string fd_exitsid="")
        {
            ResultMessage resultMessage = new ResultMessage();
            PaymentPublicHelper payHelper = new PaymentPublicHelper();
            try
            {
                if (!string.IsNullOrEmpty(fd_exitsid))
                {
                    //删除已存在fd_id 的票据信息
                    var DeleteExitsDtos = _dbContext.Landray_BillsManagement.Where(t => t.fd_id == fd_exitsid).ToList();
                    if (DeleteExitsDtos.Count > 0)
                    {
                        foreach (var DeleteExitsDto in DeleteExitsDtos)
                        {
                            _dbContext.Landray_BillsManagement.Remove(DeleteExitsDto);
                            await _dbContext.SaveChangesAsync();
                        }
                    }
                }
                if (items.Count == 0)
                {
                    resultMessage.Message = "添加项为空!";
                    resultMessage.Result = 1;
                }
                else
                {
                    //删除已新增数据
                    var DeleteDtos = _dbContext.Landray_BillsManagement.Where(t => t.fd_id == items[0].fd_id).ToList();
                    if (DeleteDtos.Count > 0)
                    {
                        foreach (var DeleteDto in DeleteDtos)
                        {
                            Logger.Info("CreateKBillInfo-" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +" 删除数据【"+ DeleteDto.BillCode + "】");
                            _dbContext.Landray_BillsManagement.Remove(DeleteDto);
                            await _dbContext.SaveChangesAsync();
                        }
                    }
                        
                    foreach (var item in items)
                    {
                        item.Flag = 0;
                        item.TaxRateText = payHelper.GetTaxRateName(item.TaxRateCode);
                        _dbContext.Landray_BillsManagement.Add(item);
                        await _dbContext.SaveChangesAsync();
                    }
                    resultMessage.Message = "添加成功！";
                    resultMessage.Result = 0;
                }
            }
            catch (System.Exception ex)
            {
                Logger.Info("BillManageController-汇入票据台账(CreateKBillInfo)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }

        /// <summary>
        /// 票据台账修改信息
        /// </summary>
        /// <param name="items">修改票据台账(Flag 0:流程中,1:已完成 ,2:已撤销)</param>
        /// <returns></returns>
        [HttpPost("BillInfoForModefied")]
        public async Task<string> ModefiedKBillInfo(List<LandrayBillsManagement> items)
        {
            ResultMessage resultMessage = new ResultMessage();
            try
            {
                string warnmessage = "";
                string errmessage = "";
                string message = "";
                int resultcode = 0;
                PaymentPublicHelper payHelper = new PaymentPublicHelper();
                if (items.Count == 0)
                {
                    errmessage = "修改项为空!";
                    resultcode = 1;
                }
                else
                {
                    foreach (var item in items)
                    {
                        var todos = _dbContext.Landray_BillsManagement.Where(t => t.fd_id == item.fd_id).Where(t => t.d_id == item.d_id).ToList();
                        if (todos.Count == 0)
                        {
                            warnmessage += "【" + item.BillCode + "】,";//修改项在数据库中未找到!
                        }
                        else
                        {
                            foreach (var todo in todos)
                            {
                                todo.ProcessName = item.ProcessName;
                                todo.Incident = item.Incident;
                                todo.BillSource = item.BillSource;
                                todo.BillCategoryValue = item.BillCategoryValue;
                                todo.BillCategoryText = item.BillCategoryText;
                                todo.AccountStatus = item.AccountStatus;
                                todo.ProjectCode = item.ProjectCode;
                                todo.ProjectName = item.ProjectName;
                                todo.SupplierCode = item.SupplierCode;
                                todo.SupplierName = item.SupplierName;
                                todo.InvoiceDate = item.InvoiceDate;
                                todo.BillCode = item.BillCode;
                                todo.BillContent = item.BillContent;
                                todo.BillAmount = item.BillAmount;
                                todo.BillTaxAmount = item.BillTaxAmount;
                                todo.TaxRateCode = item.TaxRateCode;
                                todo.TaxRateText = payHelper.GetTaxRateName(item.TaxRateCode);
                                todo.TaxRate = item.TaxRate;
                                todo.Amount = item.Amount;
                                todo.TransactorLoginName = item.TransactorLoginName;
                                todo.TransactorRealName = item.TransactorRealName;
                                todo.TransactorIdentity = item.TransactorIdentity;
                                todo.RecDate = item.RecDate;
                                todo.ConfirmDate = item.ConfirmDate;
                                todo.ConfirmLoginName = item.ConfirmLoginName;
                                todo.ConfirmRealName = item.ConfirmRealName;
                                todo.ConfirmIdentity = item.ConfirmIdentity;
                                todo.BillStatus = item.BillStatus;
                                todo.NeedAccount = item.NeedAccount;
                                todo.Vchrnum = item.Vchrnum;
                                todo.PaymentCategory = item.PaymentCategory;
                                todo.ContanctCode = item.ContanctCode;
                                todo.IsTs = item.IsTs;
                                todo.UnitJnw = item.UnitJnw;
                                todo.RelevanceInvoiceCategoryText = item.RelevanceInvoiceCategoryText;
                                todo.RelevanceInvoiceCategoryValue = item.RelevanceInvoiceCategoryValue;
                                todo.GoodClass = item.GoodClass;
                                todo.InvoicesUnitName = item.InvoicesUnitName;
                                todo.Inventory = item.Inventory;
                                todo.ExdrawbackTax = item.ExdrawbackTax;
                                todo.FormNumber = item.FormNumber;
                                todo.ReceiptorRealName = item.ReceiptorRealName;
                                todo.ReceiptorIdentity = item.ReceiptorIdentity;
                                todo.ReceiptTime = item.ReceiptTime;
                                todo.ProjectJnw = item.ProjectJnw;
                                todo.ProjectCodeMain = item.ProjectCodeMain;
                                todo.BillAmountRmb = item.BillAmountRmb;
                                todo.BillTaxAmountRmb = item.BillTaxAmountRmb;
                                todo.AmountRmb = item.AmountRmb;
                                todo.Currency = item.Currency;
                                todo.InvoiceCode = item.InvoiceCode;
                                todo.AccountDate = item.AccountDate;
                                todo.ProofCode = item.ProofCode;
                                todo.VchemInfo = item.VchemInfo;
                                todo.BillAmountCnt = item.BillAmountCnt;
                                todo.BillTaxAmountCnt = item.BillTaxAmountCnt;
                                todo.ExchangeCnt = item.ExchangeCnt;
                                todo.Flag = item.Flag;

                                _dbContext.Landray_BillsManagement.Update(todo);
                                await _dbContext.SaveChangesAsync();
                            }
                            message += "【" + item.BillCode + "】,";//修改成功
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
                Logger.Info("BillManageController-票据台账修改信息(ModefiedKBillInfo)----报错" + ex.ToString());
                throw new Exception(ex.ToString());
            }

            return resultMessage.ToJson();
        }
        #endregion
    }
}
