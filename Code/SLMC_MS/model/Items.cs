using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class Items
    {
        public static item GetItem(String itemID)
        {
            using (slmc db = new slmc())
            {
                item myItem = db.item.FirstOrDefault(i => i.itemID.Equals(itemID));
                return myItem;
            }
        }

        public static List<reserveditem> GetReservedItems(staff dealer)
        {
            using (slmc db = new slmc())
            {
                var myReserved = db.reserveditem.Where(i => i.dealerID.Equals(dealer.staffID)).Select(i => i);
                return myReserved.ToList();
            }
        }

        public static List<reserveditem> GetReservedItems(String itemID)
        {
            using (slmc db = new slmc())
            {
                var myReserved = db.reserveditem.Where(i => i.itemID.Equals(itemID) && i.availible.Equals("Y")).Select(i => i);
                return myReserved.ToList();
            }
        }

        public static reserveditem GetReservedItem(String reservedID)
        {
            using (slmc db = new slmc())
            {
                reserveditem reserveditem = db.reserveditem.FirstOrDefault(i => i.reserveID == Convert.ToInt32(reservedID));
                return reserveditem;
            }
        }

        public static void NewReservation(reserveditem reserveditem)
        {
            using (slmc db = new slmc())
            {
                db.reserveditem.Add(reserveditem);
                db.SaveChanges();
            }
        }

        public static void CancelReservation(int reservedID)
        {
            using (slmc db = new slmc())
            {
                reserveditem reserveditem = db.reserveditem.FirstOrDefault(i => i.reserveID == reservedID);
                db.reserveditem.Remove(reserveditem);
                db.SaveChanges();
            }
        }

        public static void ReplenishReservedItem(String itemID, int qty)
        {
            using(slmc db = new slmc())
            {
                List<reserveditem> reserveditems = db.reserveditem.Where(i => i.itemID.Equals(itemID) && i.availible.Equals("P")).ToList();
                foreach(reserveditem item in reserveditems)
                {
                    if (qty >= item.reservedAmt)
                    {
                        item.availible = "Y";
                        qty -= item.reservedAmt;
                    } else
                    {
                        item.availible = "N";
                    }
                }
            }
        }

        public static void ModifyReservation(int reservedID, int qty)
        {
            using (slmc db = new slmc())
            {
                reserveditem reserveditem = db.reserveditem.FirstOrDefault(i => i.reserveID == reservedID);
                reserveditem.reservedAmt = qty;
                db.SaveChanges();
            }
        }

        public static int GetTotalReservedAmount(String itemID)
        {
            return GetReservedItems(itemID).Select(i => i.reservedAmt).Sum();
        }

        public static itemprice GetItemPrice(String itemID, DateTime date)
        {
            using (slmc db = new slmc())
            {
                var itemPrice = db.itemprice.OrderByDescending(i => i.issueDate).FirstOrDefault(i => i.itemID.Equals(itemID) && i.issueDate <= date);
                return itemPrice;
            }
        }

        public static double GetPurchasePrice(String itemID, DateTime date)
        {
            return GetItemPrice(itemID, date).purchasePrice;
        }

        public static double GetSellingPrice(String itemID, DateTime date)
        {
            using (slmc db = new slmc())
            {
                var itemPrice = db.itemprice.OrderByDescending(i => i.issueDate).FirstOrDefault(i => i.itemID.Equals(itemID) && i.issueDate <= date);
                return itemPrice.sellingPrice;
            }
        }

        public static void Add(item item, itemprice itemprice)
        {
            using (slmc db = new slmc())
            {
                db.item.Add(item);
                item.itemprice.Add(itemprice);
                itemprice.item = item;
                db.SaveChanges();
            }
        }

        public static int GetAvailableAmount(String itemID)
        {
            using (slmc db = new slmc())
            {
                item item = db.item.FirstOrDefault(i => i.itemID.Equals(itemID));
                return item.actualStock - item.orderedAmt - Items.GetTotalReservedAmount(itemID);
            }
        }

        public static void AddPriceRecord(itemprice itemprice)
        {
            using (slmc db = new slmc())
            {
                itemprice current = db.itemprice.OrderByDescending(i => i.issueDate).FirstOrDefault(i => i.itemID.Equals(itemprice.itemID) && i.issueDate <= DateTime.Today);

                if (DateTime.Compare(current.issueDate, itemprice.issueDate) == 0) 
                {                               // Modify the current item price if the issue date is on the same date
                    current.purchasePrice = itemprice.purchasePrice;
                    current.sellingPrice = itemprice.sellingPrice;
                    db.SaveChanges();
                }
                else if(current.purchasePrice != itemprice.purchasePrice || current.sellingPrice != itemprice.sellingPrice)
                {                               // Check if the new record different from the current record
                    db.itemprice.Add(itemprice);
                    db.SaveChanges();
                }
            }
        }
        
        public static void ModifyItem(item newData)
        {
            using (slmc db = new slmc())
            {
                item targetItem = db.item.FirstOrDefault(i => i.itemID.Equals(newData.itemID));
                targetItem.name = newData.name;
                targetItem.name_ch = newData.name_ch;
                targetItem.description = newData.description;
                targetItem.actualStock = newData.actualStock;
                targetItem.locatedShelf = newData.locatedShelf;
                targetItem.weight = newData.weight;
                db.SaveChanges();
            }
        }

        public static List<item> GetItems()
        {
            using (slmc db = new slmc())
            {
                var items = db.item.Select(i => i);
                return items.ToList();
            }
        }

        public static List<item> FindItemsByName(String name)
        {
            using (slmc db = new slmc())
            {
                var items = db.item.Where(i => i.name.Contains(name) || i.name_ch.Contains(name)).Select(i => i);
                return items.ToList();
            }
        }

        public static void SetDangerLine(String itemID, int dangerLine)
        {
            using (slmc content = new slmc())
            {
                //update the level line
                item items = content.item.FirstOrDefault(i => i.itemID == itemID);
                items.dangerLevel = dangerLine;
                content.SaveChanges();
            }
        }

        public static void SetReorderLine(String itemID, int reorderLine)
        {
            using (slmc content = new slmc())
            {
                //update the level line
                item items = content.item.FirstOrDefault(i => i.itemID == itemID);
                items.reorderLevel = reorderLine;
                content.SaveChanges();
            }
        }

        public static void SetLocatedShelf(String itemID, String location)
        {
            using (slmc content = new slmc())
            {
                item items = content.item.FirstOrDefault(i => i.itemID == itemID);
                items.locatedShelf = location;
                content.SaveChanges();
            }
        }

        public static int salesNum(String itemID,int month,int year)
        {
            int totalNum = 0;
            DateTime min = new DateTime(year, month, 1);
            DateTime max = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            using (slmc db = new slmc())
            {
                var query = from list in db.orderitem
                            where list.itemID.Equals(itemID) && list.order.statusID.Equals("copl") && list.order.orderDate >= min && list.order.orderDate <= max
                            select list;
                if(query!=null)
                    totalNum = query.ToList().Select(i => i.qty).Sum();
            }
            return totalNum;
        }

        public static bool hasReorderItem()
        {
            using(slmc db = new slmc())
            {
                var items = (from list in db.item
                            where (list.actualStock - list.orderedAmt) <= list.reorderLevel
                            select list).ToList();

                foreach(item item in items)
                {
                    if ((item.actualStock - item.orderedAmt - GetTotalReservedAmount(item.itemID)) > item.reorderLevel)
                        items.Remove(item);
                }

                if (items.Count() <= 0)
                    return false;
                else
                    return true;
            }
        }
    }
}
