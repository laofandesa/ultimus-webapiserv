﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccWagePaymentHistroy20160225bak
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public string ProcessName { get; set; }
        public int? IncidentNo { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Dept { get; set; }
        public string DeptCode { get; set; }
        public string UserName { get; set; }
        public decimal? WagesShould { get; set; }
        public decimal? RealWages { get; set; }
        public decimal? WageIncomTaxPable { get; set; }
        public decimal? WagePersonalTax { get; set; }
        public decimal? FixWages { get; set; }
        public decimal? PostAllowance { get; set; }
        public decimal? ReservationWage { get; set; }
        public decimal? CompanyAllowance { get; set; }
        public decimal? SalaryIncrease { get; set; }
        public decimal? OtherAllowance { get; set; }
        public decimal? SpecialAllowance { get; set; }
        public decimal? MeritPay { get; set; }
        public decimal? Reissue { get; set; }
        public decimal? Leaves { get; set; }
        public decimal? SpecialDebit { get; set; }
        public decimal? TotalDebit { get; set; }
        public decimal? ProvidentFundRate { get; set; }
        public decimal? Annuity { get; set; }
        public decimal? PensionInsurance { get; set; }
        public decimal? MedicalInsurance { get; set; }
        public decimal? UnemploymentInsurance { get; set; }
        public decimal? LargeMedicalal { get; set; }
        public decimal? ProvidentFund { get; set; }
        public decimal? ProvidentFundRepay { get; set; }
        public decimal? Rent { get; set; }
        public string Cardholder { get; set; }
        public string BankAccount { get; set; }
        public string SalaryVest { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? SalaryLevel { get; set; }
        public int? ChangeType { get; set; }
        public decimal? CompanyIncomTaxPable { get; set; }
        public decimal? CompanyPersonalTax { get; set; }
        public decimal? WorkingMeals { get; set; }
        public decimal? TransportSubsidies { get; set; }
        public decimal? CommunicationSubsidies { get; set; }
        public decimal? HolidaySubsidies { get; set; }
        public string Editor { get; set; }
        public decimal? ForthAwardMoney { get; set; }
        public decimal? ZhunYuKouChu { get; set; }
        public decimal? YingFaGongZi { get; set; }
        public decimal? ShiFaGongZi { get; set; }
        public decimal? SheBaoHeJi { get; set; }
        public int? CanBeRead { get; set; }
        public decimal? JiXiaoGongZi { get; set; }
        public decimal? JiaBanFei { get; set; }
        public int? PersonStatus { get; set; }
        public decimal? AnnuityPreTax { get; set; }
        public string NewSalaryVest { get; set; }
        public int? WageStatus { get; set; }
        public int? SocialSecurityStatus { get; set; }
        public int? AnnuityStatus { get; set; }
        public int? FundStatus { get; set; }
        public int? CarryoverDeptWageCarryoverDebitStatus { get; set; }
        public int? CarryoverProjectWageCarryoverDebitStatus { get; set; }
        public int? CarryoverWageAndSubsidyStatus { get; set; }
        public int? CarryoverInjuryInsuranceStatus { get; set; }
        public int? CarryoverAnnuityStatus { get; set; }
        public int? CarryoverMaternityInsuranceStatus { get; set; }
        public int? CarryoverUnemploymentInsuranceStatus { get; set; }
        public int? CarryoverPensionInsuranceStatus { get; set; }
        public int? CarryoverMedicalInsuranceStatus { get; set; }
        public int? CarryoverFundStatus { get; set; }
        public decimal? ZaiGangBuTie { get; set; }
        public decimal? NewProvidentFund { get; set; }
        public string SheBaoGuiShu { get; set; }
        public string GongJiJinGuiShu { get; set; }
        public decimal? FuLi { get; set; }
        public int? WageStatusForSupplementary { get; set; }
        public int? AnnuityStatusForSupplementary { get; set; }
        public int? FundStatusForSupplementary { get; set; }
        public int? SocialSecurityStatusForSupplementary { get; set; }
        public int? CarryoverDeptWageCarryoverDebitStatusForSupplementary { get; set; }
        public int? CarryoverProjectWageCarryoverDebitStatusForSupplementary { get; set; }
        public int? CarryoverWageAndSubsidyStatusForSupplementary { get; set; }
        public int? CarryoverInjuryInsuranceStatusForSupplementary { get; set; }
        public int? CarryoverAnnuityStatusForSupplementary { get; set; }
        public int? CarryoverMaternityInsuranceStatusForSupplementary { get; set; }
        public int? CarryoverUnemploymentInsuranceStatusForSupplementary { get; set; }
        public int? CarryoverPensionInsuranceStatusForSupplementary { get; set; }
        public int? CarryoverMedicalInsuranceStatusForSupplementary { get; set; }
        public int? CarryoverFundStatusForSupplementary { get; set; }
        public decimal? KouKuan { get; set; }
        public int? IsForthAward { get; set; }
        public decimal? HuiFei { get; set; }
        public decimal? NaShuiTiaoZheng { get; set; }
        public decimal? QiTaBuTie { get; set; }
        public int? PersonStatusDetail { get; set; }
        public decimal? BeiYongJin { get; set; }
        public decimal? FengXianJin { get; set; }
    }
}
