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
    
    public partial class invoice
    {
        public int invID { get; set; }
        public int orderID { get; set; }
        public System.DateTime invDate { get; set; }
        public double invAmt { get; set; }
        public string validated { get; set; }
    
        public virtual order order { get; set; }
    }
}
