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
    
    public partial class goodsreceivenote
    {
        public goodsreceivenote()
        {
            this.goodsreceiveitem = new HashSet<goodsreceiveitem>();
        }
    
        public int noteID { get; set; }
        public string supplierID { get; set; }
        public System.DateTime inwardDate { get; set; }
        public string confirmed { get; set; }
    
        public virtual ICollection<goodsreceiveitem> goodsreceiveitem { get; set; }
        public virtual supplier supplier { get; set; }
    }
}