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
    
    public partial class PPM_ProblemTrace
    {
        public PPM_ProblemTrace()
        {
            this.PPM_MessageRecord = new HashSet<PPM_MessageRecord>();
            this.PPM_ProblemTraceImage = new HashSet<PPM_ProblemTraceImage>();
        }
    
        public int ID { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectUse { get; set; }
        public string Module { get; set; }
        public string Menu { get; set; }
        public string Problem { get; set; }
        public string FindPersonCode { get; set; }
        public string FindPerson { get; set; }
        public Nullable<System.DateTime> FindDate { get; set; }
        public string Priority { get; set; }
        public byte[] ProPicture { get; set; }
        public string ProPicturePath { get; set; }
        public string DealPersonCode { get; set; }
        public string DealPerson { get; set; }
        public string TestPersonCode { get; set; }
        public string TestPerson { get; set; }
        public Nullable<System.DateTime> TestPassDate { get; set; }
        public Nullable<System.DateTime> BeginDealDate { get; set; }
        public Nullable<System.DateTime> EndDealDate { get; set; }
        public string Solution { get; set; }
        public byte[] DealPicture { get; set; }
        public string DealPicturePath { get; set; }
        public string Status { get; set; }
        public string ProjectManagerCode { get; set; }
        public string ProjectManager { get; set; }
        public string TeamLeaderCode { get; set; }
        public string TeamLeader { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePerson { get; set; }
        public Nullable<byte> DeleteFlag { get; set; }
        public Nullable<byte> TestFlag { get; set; }
        public Nullable<byte> FormalFlag { get; set; }
        public string ProblemType { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentUniqueID { get; set; }
        public string AttachmentCreateBy { get; set; }
        public Nullable<System.DateTime> AttachmentCreateDate { get; set; }
        public Nullable<int> ProjectPlanID { get; set; }
        public string IsRepeat { get; set; }
    
        public virtual ICollection<PPM_MessageRecord> PPM_MessageRecord { get; set; }
        public virtual PPM_ProblemTrace PPM_ProblemTrace1 { get; set; }
        public virtual PPM_ProblemTrace PPM_ProblemTrace2 { get; set; }
        public virtual PPM_ProblemTrace PPM_ProblemTrace11 { get; set; }
        public virtual PPM_ProblemTrace PPM_ProblemTrace3 { get; set; }
        public virtual PPM_ProblemTrace PPM_ProblemTrace12 { get; set; }
        public virtual PPM_ProblemTrace PPM_ProblemTrace4 { get; set; }
        public virtual PPM_ProjectInfo PPM_ProjectInfo { get; set; }
        public virtual PPM_ProjectPlan PPM_ProjectPlan { get; set; }
        public virtual SYS_User SYS_User { get; set; }
        public virtual SYS_User SYS_User1 { get; set; }
        public virtual SYS_User SYS_User2 { get; set; }
        public virtual SYS_User SYS_User3 { get; set; }
        public virtual SYS_User SYS_User4 { get; set; }
        public virtual SYS_User SYS_User5 { get; set; }
        public virtual ICollection<PPM_ProblemTraceImage> PPM_ProblemTraceImage { get; set; }
    }
}