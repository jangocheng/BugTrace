//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JAJ.WinForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class PPM_ProjectPlan
    {
        public PPM_ProjectPlan()
        {
            this.PPM_ProblemTrace = new HashSet<PPM_ProblemTrace>();
        }
    
        public int ID { get; set; }
        public string BusinessCode { get; set; }
        public string ProjectCode { get; set; }
        public string Unit { get; set; }
        public string Activity { get; set; }
        public string Task { get; set; }
        public Nullable<decimal> BudgetWorkload { get; set; }
        public Nullable<System.DateTime> BudgetBeginDate { get; set; }
        public Nullable<System.DateTime> BudgetEndDate { get; set; }
        public Nullable<decimal> RealWorkload { get; set; }
        public Nullable<System.DateTime> RealBeginDate { get; set; }
        public Nullable<System.DateTime> RealEndDate { get; set; }
        public Nullable<System.DateTime> RealTestEndDate { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> ProgressRate { get; set; }
        public string DiffAnalyze { get; set; }
        public string ResourceCode { get; set; }
        public string ResourceName { get; set; }
        public string TestResourceCode { get; set; }
        public string TestResourceName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePerson { get; set; }
        public Nullable<byte> DeleteFlag { get; set; }
        public string Memo { get; set; }
        public string PlanType { get; set; }
        public Nullable<byte> HideFlag { get; set; }
        public Nullable<int> ParentPlanID { get; set; }
    
        public virtual PPM_ProjectInfo PPM_ProjectInfo { get; set; }
        public virtual SYS_User SYS_User { get; set; }
        public virtual SYS_User SYS_User1 { get; set; }
        public virtual ICollection<PPM_ProblemTrace> PPM_ProblemTrace { get; set; }
    }
}
