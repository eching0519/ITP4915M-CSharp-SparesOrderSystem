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
    
    public partial class item
    {
        public item()
        {
            this.goodsreceiveitem = new HashSet<goodsreceiveitem>();
            this.itemprice = new HashSet<itemprice>();
            this.orderitem = new HashSet<orderitem>();
            this.replenishitem = new HashSet<replenishitem>();
            this.reserveditem = new HashSet<reserveditem>();
        }
    
        public string itemID { get; set; }
        public string name { get; set; }
        public string name_ch { get; set; }
        public string description { get; set; }
        public int orderedAmt { get; set; }
        public int actualStock { get; set; }
        public string locatedShelf { get; set; }
        public Nullable<int> dangerLevel { get; set; }
        public Nullable<int> reorderLevel { get; set; }
        public string supplierID { get; set; }
        public double weight { get; set; }
    
        public virtual ICollection<goodsreceiveitem> goodsreceiveitem { get; set; }
        public virtual supplier supplier { get; set; }
        public virtual ICollection<itemprice> itemprice { get; set; }
        public virtual ICollection<orderitem> orderitem { get; set; }
        public virtual ICollection<replenishitem> replenishitem { get; set; }
        public virtual ICollection<reserveditem> reserveditem { get; set; }
    }
}
