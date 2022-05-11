using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class DespatchNotes
    {
        public static despatchnote GetDespatchnote(int despatchID)
        {
            using (slmc db = new slmc())
            {
                var dNote = db.despatchnote.FirstOrDefault(i => i.despatchID == despatchID);
                return dNote;
            }
        }

        public static void Add(despatchnote despatchnote)
        {
            using (slmc db = new slmc())
            {
                db.despatchnote.Add(despatchnote);
                db.SaveChanges();
            }
        }

        public static void UpdateDeliveryDate(despatchnote despatchnote)
        {
            using (slmc db = new slmc())
            {
                var orderTimes = db.order.Where(i => i.despatchID == despatchnote.despatchID).Select(i => i.expDeliverTime);
                DateTime myDate = orderTimes.Min();

                var myDespatchNote = db.despatchnote.FirstOrDefault(i => i.despatchID == despatchnote.despatchID);
                myDespatchNote.deliveryDate = myDate;
                db.SaveChanges();
            }
        }

        public static void AddDespatchOrder(despatchnote despatchnote, order order)
        {
            using (slmc db = new slmc())
            {
                despatchnote despatchNote = db.despatchnote.FirstOrDefault(i => i.despatchID == despatchnote.despatchID);
                despatchNote.order.Add(order);
                order.statusID = OrderStatus.Assembled.statusID;
                db.SaveChanges();
            }
        }


        public static void SetStoremen(int despatchID, staff storemen)
        {
            using (slmc db = new slmc())
            {
                // Update the packing handler
                var dNote = db.despatchnote.FirstOrDefault(i => i.despatchID == despatchID);
                dNote.storemen = storemen.staffID;

                // Update order status
                var orderList = dNote.order;
                foreach (order myOrder in orderList.ToList())
                {
                    myOrder.statusID = OrderStatus.Packing.statusID;
                }

                db.SaveChanges();
            }
        }

        public static void SetOrdersToDelivering(int despatchID, staff clerk)
        {
            using (slmc db = new slmc())
            {
                // Update the packing handler
                var dNote = db.despatchnote.FirstOrDefault(i => i.despatchID == despatchID);
                dNote.clerk = clerk.staffID;

                // Update order status and create invoice
                var orderList = dNote.order;
                foreach (order myOrder in orderList.ToList())
                {
                    myOrder.statusID = OrderStatus.Delivering.statusID;

                    double invAmt = Orders.GetOrderTotal(myOrder.orderID);
                    invoice inv = new invoice
                    {
                        orderID = myOrder.orderID,
                        invDate = DateTime.Today,
                        invAmt = invAmt,
                        validated = "Y"
                    };
                    db.invoice.Add(inv);
                    db.SaveChanges();

                    // export invoice PDF
                    Invoice invoice = new Invoice(myOrder);
                    invoice.exportPDF();
                }

                db.SaveChanges();
            }
        }

        public static void Packed(int despatchID)
        {
            using (slmc db = new slmc())
            {
                // Update the packing handler
                var dNote = db.despatchnote.FirstOrDefault(i => i.despatchID == despatchID);
                dNote.packed = "Y";
                
                // Remove the item actual stock
                foreach(order o in dNote.order.ToList())
                {
                    List<orderitem> oItems = db.orderitem.Where(i => i.orderID == o.orderID).ToList();
                    foreach(orderitem oi in oItems)
                    {
                        item item = db.item.FirstOrDefault(i => i.itemID.Equals(oi.itemID));
                        item.orderedAmt -= oi.qty;
                        item.actualStock -= oi.qty;
                    }
                }

                db.SaveChanges();
            }
        }

        public static List<despatchnote> GetPendingDespatchNotes(province province)
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.provinceID.Equals(province.provinceID) && i.storemen == null && i.packed.Equals("N")).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<despatchnote> GetUnpackedDespatchNotes(staff storemen)
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.storemen.Equals(storemen.staffID) && i.packed.Equals("N")).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<despatchnote> GetPackedDespatchNotes(staff storemen)
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.storemen.Equals(storemen.staffID) && i.packed.Equals("Y")).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<despatchnote> GetPackedDespatchNotes()
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.clerk == null && i.packed.Equals("Y")).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<despatchnote> FindPackedDespatchNotes(province province)
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.clerk == null && i.packed.Equals("Y") && i.provinceID.Equals(province.provinceID)).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<despatchnote> FindPackedDespatchNotes(int despatchID)
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.clerk == null && i.packed.Equals("Y") && i.despatchID == despatchID).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<despatchnote> FindPackedDespatchNotes(province province,int despatchID)
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.clerk == null && i.packed.Equals("Y") && i.provinceID.Equals(province.provinceID) &&
                                                                  i.despatchID == despatchID).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<despatchnote> FindCompletedDespatchNotes(province province)
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.clerk != null && i.provinceID.Equals(province.provinceID)).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<despatchnote> FindCompletedDespatchNotes(int despatchID)
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.clerk != null && i.despatchID == despatchID).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<despatchnote> FindCompletedDespatchNotes(province province, int despatchID)
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.clerk != null && i.provinceID.Equals(province.provinceID) &&
                                                                  i.despatchID == despatchID).Select(i => i);
                return despatchNoteList.ToList();
            }
        }


        public static List<despatchnote> GetDeliveredDespatchNotes(staff clerk)
        {
            if (Staffs.isDespatchClerk(clerk))
            {
                using (slmc db = new slmc())
                {
                    var despatchNoteList = db.despatchnote.Where(i => i.clerk.Equals(clerk.staffID)).Select(i => i);
                    return despatchNoteList.ToList();
                }
            }
            else
            {
                using (slmc db = new slmc())
                {
                    var despatchNoteList = db.despatchnote.Where(i => i.clerk != null).Select(i => i);
                    return despatchNoteList.ToList();
                }
            }
        }

        public static List<despatchnote> GetDeliveredDespatchNotes()
        {
            using (slmc db = new slmc())
            {
                var despatchNoteList = db.despatchnote.Where(i => i.clerk != null).Select(i => i);
                return despatchNoteList.ToList();
            }
        }

        public static List<order> GetDespatchOrders(int despatchID)
        {
            using (slmc db = new slmc())
            {
                List<order> despatchOrders = new List<order>();

                var despatchNote = db.despatchnote.Where(i => i.despatchID == despatchID).Select(i => i.order);
                foreach (var dn in despatchNote.ToList())
                    foreach (var order in dn.ToList())
                        despatchOrders.Add(order);

                return despatchOrders;
            }
        }
    }
}
