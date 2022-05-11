using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class GoodsReceivedNotes
    {
        public static List<goodsreceivenote> getGRNList()
        {
            using (slmc content = new slmc())
            {
                var getGRNList = content.goodsreceivenote.Select(i => i);
                return getGRNList.ToList();
            }
        }

        public static List<goodsreceivenote> GetGRNs()
        {
            using (slmc db = new slmc())
            {
                return db.goodsreceivenote.ToList();
            }
        }

        public static goodsreceivenote GetGRN(int noteID)
        {
            using (slmc db = new slmc())
            {
                return db.goodsreceivenote.FirstOrDefault(i => i.noteID == noteID);
            }
        }

        public static List<goodsreceiveitem> GetGRNitems(int noteID)
        {
            using (slmc db = new slmc())
            {
                return db.goodsreceiveitem.Where(i => i.noteID == noteID).ToList();
            }
        }

        public static void Add(goodsreceivenote goodsreceivenote, List<goodsreceiveitem> goodsreceiveitems)
        {
            using (slmc db = new slmc())
            {
                db.goodsreceivenote.Add(goodsreceivenote);
                foreach (goodsreceiveitem i in goodsreceiveitems)
                    goodsreceivenote.goodsreceiveitem.Add(i);
                db.SaveChanges();
            }
        }

        public static void Reject(int noteID)
        {
            using (slmc db = new slmc())
            {
                goodsreceivenote note = db.goodsreceivenote.FirstOrDefault(i => i.noteID == noteID);
                note.confirmed = "R";
                db.SaveChanges();
            }
        }

        public static void Confirm(int noteID)
        {
            using (slmc db = new slmc())
            {
                goodsreceivenote note = db.goodsreceivenote.FirstOrDefault(i => i.noteID == noteID);
                note.confirmed = "Y";

                List<goodsreceiveitem> goodsreceiveitems = db.goodsreceiveitem.Where(i => i.noteID == noteID).ToList();
                foreach(goodsreceiveitem grnItem in goodsreceiveitems)
                {
                    item item = db.item.FirstOrDefault(i => i.itemID.Equals(grnItem.itemID));
                    item.actualStock += grnItem.qty;

                    Items.ReplenishReservedItem(grnItem.itemID, grnItem.qty);
                }

                db.SaveChanges();
            }
        }

        public static void Update(int noteID, List<goodsreceiveitem> goodsreceiveitems)
        {
            using (slmc db = new slmc())
            {
                goodsreceivenote note = db.goodsreceivenote.FirstOrDefault(i => i.noteID == noteID);
                note.goodsreceiveitem.Clear();

                foreach (goodsreceiveitem i in goodsreceiveitems)
                    note.goodsreceiveitem.Add(i);

                note.confirmed = "N";
                db.SaveChanges();
            }
        }
    }
}
