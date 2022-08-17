using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccSheBaoHistroy
    {
        public int Id { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string NewSalaryVest { get; set; }
        public string UserName { get; set; }
        public string UserIdentityId { get; set; }
        public string UserLoginName { get; set; }
        public decimal? YiLiaoGongSi { get; set; }
        public decimal? YiLiaoGeRen { get; set; }
        public decimal? YangLaoGongSi { get; set; }
        public decimal? YangLaoGeRen { get; set; }
        public decimal? ShiYeGongSi { get; set; }
        public decimal? ShiYeGeRen { get; set; }
        public decimal? GongShangGeRen { get; set; }
        public decimal? ShengYuGeRen { get; set; }
        public decimal? GongJiJinGongSi { get; set; }
        public decimal? GongJiJinGeRen { get; set; }
        public decimal? QiYeNianJinGongSi { get; set; }
        public decimal? QiYeNianJinGeRen { get; set; }
        public string SalaryVest { get; set; }
        public string SheBaoGuiShui { get; set; }
        public string GongJinJinGuiShui { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public decimal? DaEyiLiao { get; set; }
        public decimal? GongJiJinGeRen2 { get; set; }
        public decimal? GongJiJinGeRenBuJiao { get; set; }
        public decimal? GongJinJinGongSi2 { get; set; }
        public decimal? GongJiJinGongSiBuJiao { get; set; }
        public decimal? AnYueZhuFangBuTie { get; set; }
        public decimal? SheBaoJiShu { get; set; }
    }
}
