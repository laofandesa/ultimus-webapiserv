using System;
using System.Collections.Generic;

#nullable disable

namespace TCC_WebAPI.Models
{
    public partial class TccHrmLyapply
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public int? Incident { get; set; }
        public int? ProcessStatus { get; set; }
        public string ApplyLoginUser { get; set; }
        public string ApplyName { get; set; }
        public string ApplyPhone { get; set; }
        public string ApplyDeptNo { get; set; }
        public string ApplyDept { get; set; }
        public string ApplyDate { get; set; }
        public string CreatDate { get; set; }
        public string FormNumber { get; set; }
        public string EmpType { get; set; }
        public string EmpTypeId { get; set; }
        public string ContractType { get; set; }
        public string ContractTypeId { get; set; }
        public string Summary { get; set; }
        public string ComeInType { get; set; }
        public string ComeInTypeId { get; set; }
        public string EmpBelong { get; set; }
        public string EmpBelongId { get; set; }
        public string DeptLeaderNum { get; set; }
        public string SubmitDeptLeaderNum { get; set; }
        public string DeptMainLeaderNum { get; set; }
        public string SubmitDeptMainLeaderNum { get; set; }
        public string ProjectLeaderNum { get; set; }
        public string SubmitProjectLeaderNum { get; set; }
        public string ProjectMainLeaderNum { get; set; }
        public string SubmitProjectMainLeaderNum { get; set; }
        public string HasprojectMainLeader { get; set; }
        public string IsOutProject { get; set; }
    }
}
