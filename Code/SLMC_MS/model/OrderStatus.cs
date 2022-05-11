using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class OrderStatus
    {
        public static readonly orderstatus Processing = new orderstatus { statusID = "proc", status = "Processing" };
        public static readonly orderstatus Assembled = new orderstatus { statusID = "assm", status = "Assembled" };
        public static readonly orderstatus Packing = new orderstatus { statusID = "pack", status = "Packing" };
        public static readonly orderstatus Delivering = new orderstatus { statusID = "delv", status = "Delivering" };
        public static readonly orderstatus Complete = new orderstatus { statusID = "copl", status = "Complete" };
        public static readonly orderstatus Cancel = new orderstatus { statusID = "cacl", status = "Cancel" };
    }
}
