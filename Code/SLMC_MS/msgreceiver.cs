//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLMC_MS
{
    using System;
    using System.Collections.Generic;
    
    public partial class msgreceiver
    {
        public int msgID { get; set; }
        public string receiverID { get; set; }
        public string readed { get; set; }
    
        public virtual broadcastmsg broadcastmsg { get; set; }
        public virtual staff staff { get; set; }
    }
}
