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
    
    public partial class SYS_UserExt
    {
        public string UserCode { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string ServiceName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string TempTableName { get; set; }
        public string EmailPassword { get; set; }
        public string CommonProject { get; set; }
    
        public virtual SYS_User SYS_User { get; set; }
    }
}
