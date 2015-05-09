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
    
    public partial class PPM_ProjectInfo
    {
        public PPM_ProjectInfo()
        {
            this.PPM_ProjectPlan = new HashSet<PPM_ProjectPlan>();
            this.PPM_ProjectTeam = new HashSet<PPM_ProjectTeam>();
            this.SYS_User1 = new HashSet<SYS_User>();
            this.PPM_ProblemTrace = new HashSet<PPM_ProblemTrace>();
        }
    
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<System.DateTime> OnLineDate { get; set; }
        public string ProjectManagerCode { get; set; }
        public Nullable<System.DateTime> TestPublishDate { get; set; }
        public Nullable<System.DateTime> FormalPublishDate { get; set; }
        public string UsedCustom { get; set; }
        public Nullable<byte> NeedPMCheck { get; set; }
        public string SVN { get; set; }
        public string DevServerInfo { get; set; }
        public string TestServerInfo { get; set; }
        public string PubServerInfo { get; set; }
        public string RequireDoc { get; set; }
        public string UIPrototype { get; set; }
        public string OpInstruction { get; set; }
        public string OtherInfo { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatePerson { get; set; }
    
        public virtual SYS_User SYS_User { get; set; }
        public virtual ICollection<PPM_ProjectPlan> PPM_ProjectPlan { get; set; }
        public virtual ICollection<PPM_ProjectTeam> PPM_ProjectTeam { get; set; }
        public virtual ICollection<SYS_User> SYS_User1 { get; set; }
        public virtual ICollection<PPM_ProblemTrace> PPM_ProblemTrace { get; set; }
    }
}
