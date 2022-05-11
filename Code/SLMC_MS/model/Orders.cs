using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class Orders
    {
        public static List<order> GetOrders()
        {
            using (slmc db = new slmc())
            {
                var orders = db.order.Select(i => i);
                return orders.ToList();
            }
        }

        public static order GetOrder(int orderID)
        {
            using (slmc db = new slmc())
            {
                order myOrder = db.order.FirstOrDefault(i => i.orderID == orderID);
                return myOrder;
            }
        }

        public static List<order> GetOrders(staff staff)
        {
            using (slmc db = new slmc())
            {
                var orders = db.order.Where(i => i.dealerID.Equals(staff.staffID)).Select(i => i);
                return orders.ToList();
            }
        }

        public static List<order> GetOrders(city city, orderstatus orderstatus)
        {
            return GetOrders(city.cityID, orderstatus);
        }

        public static List<order> GetOrders(String cityID, orderstatus orderstatus)
        {
            using (slmc db = new slmc())
            {
                var orders = db.order.Where(i => i.cityID.Equals(cityID) && i.statusID.Equals(orderstatus.statusID)).Select(i => i);
                return orders.ToList();
            }
        }

        public static List<order> GetIncompletedOrders(staff staff)
        {
            using (slmc db = new slmc())
            {
                var orders = db.order.Where(i => i.dealerID.Equals(staff.staffID) && !(i.statusID.Equals("copl") || i.statusID.Equals("cacl"))).Select(i => i);
                return orders.ToList();
            }
        }
        public static List<order> GetCompletedOrders(staff staff)
        {
            using (slmc db = new slmc())
            {
                DateTime previous30Days = DateTime.Today.AddDays(-30);
                var orders = db.order.Where(i => i.dealerID.Equals(staff.staffID) && (i.statusID.Equals("copl") || i.statusID.Equals("cacl")) && i.orderDate >= previous30Days).Select(i => i);
                return orders.ToList();
            }
        }

        public static List<order> GetOrders(staff staff, orderstatus orderstatus)
        {
            using (slmc db = new slmc())
            {
                var orders = db.order.Where(i => i.dealerID.Equals(staff.staffID) && i.statusID.Equals(orderstatus.statusID)).Select(i => i);
                return orders.ToList();
            }
        }

        public static List<order> GetOrders(team team)
        {
            using (slmc db = new slmc())
            {
                var orders = from list in db.order
                            where list.staff.teamID.Equals(team.teamID)
                            select list;
                return orders.ToList() ;
            }
        }

        public static orderitem GetOrderitem(order order, String itemID)
        {
            using (slmc db = new slmc())
            {
                orderitem orderitem = db.orderitem.FirstOrDefault(i => i.orderID == order.orderID && i.itemID.Equals(itemID));
                return orderitem;
            }
        }

        public static String GetOrderStatus(int orderID)
        {
            using (slmc db = new slmc())
            {
                order myOrder = db.order.FirstOrDefault(i => i.orderID == orderID);
                return GetOrderStatus(myOrder);
            }
        }

        public static String GetOrderStatus(order order)
        {
            using (slmc db = new slmc())
            {
                orderstatus orderstatus = db.orderstatus.FirstOrDefault(i => i.statusID.Equals(order.statusID));
                return orderstatus.status;
            }
        }

        public static bool isProcessing(order order)
        {
            return order.statusID.Equals("proc");
        }

        public static void Processing(order order)
        {
            using (slmc db = new slmc())
            {
                var myOrder = db.order.FirstOrDefault(i => i.orderID == order.orderID);
                myOrder.statusID = "proc";
                db.SaveChanges();
            }
        }

        public static bool isPacking(order order)
        {
            return order.statusID.Equals("pack");
        }

        public static void Packing(order order)
        {
            using (slmc db = new slmc())
            {
                var myOrder = db.order.FirstOrDefault(i => i.orderID == order.orderID);
                myOrder.statusID = "pack";
                db.SaveChanges();
            }
        }

        public static bool isDelivering(order order)
        {
            return order.statusID.Equals("delv");
        }

        public static void Delivering(order order)
        {
            using (slmc db = new slmc())
            {
                var myOrder = db.order.FirstOrDefault(i => i.orderID == order.orderID);
                myOrder.statusID = "delv";
                db.SaveChanges();
            }
        }

        public static bool isCompleted(order order)
        {
            return order.statusID.Equals("copl");
        }
        public static void Complete(order order)
        {
            using (slmc db = new slmc())
            {
                var myOrder = db.order.FirstOrDefault(i => i.orderID == order.orderID);
                myOrder.statusID = "copl";

                db.SaveChanges();
            }
        }

        public static bool isCancel(order order)
        {
            return order.statusID.Equals("cacl");
        }

        public static void Cancel(order order)
        {
            using (slmc db = new slmc())
            {
                var myOrder = db.order.FirstOrDefault(i => i.orderID == order.orderID);
                myOrder.statusID = "cacl";

                var orderItemList = db.orderitem.Where(i => i.orderID == myOrder.orderID);
                foreach (var orderItem in orderItemList.ToList())
                {
                    item I = db.item.FirstOrDefault(i => i.itemID.Equals(orderItem.itemID));
                    I.orderedAmt -= orderItem.qty;
                }
                
                db.SaveChanges();
            }
        }

        public static bool isAssembled(order order)
        {
            return order.statusID.Equals("assm");
        }

        public static void Assembled(order order)
        {
            using (slmc db = new slmc())
            {
                var myOrder = db.order.FirstOrDefault(i => i.orderID == order.orderID);
                myOrder.statusID = "assm";
                db.SaveChanges();
            }
        }

        public static List<orderitem> GetOrderItemList(order order)
        {
            using (slmc db = new slmc())
            {
                var orderItemList = db.orderitem.Where(i => i.orderID == order.orderID).Select(i => i);
                return orderItemList.ToList();
            }
        }

        public static void SetOrder(int orderID, DateTime expectDate, String cityID, String deliveryAddress, String invoiceName, String invoiceAddress, double weight)
        {
            using (slmc db = new slmc())
            {
                order myOrder = db.order.FirstOrDefault(i => i.orderID == orderID);
                myOrder.deliveryAddress = deliveryAddress;
                myOrder.cityID = cityID;
                myOrder.expDeliverTime = expectDate;
                myOrder.invName = invoiceName;
                myOrder.invAddress = invoiceAddress;
                myOrder.weight = weight;
                db.SaveChanges();
            }
        }

        public static void RemoveOrderItems(int orderID)
        {
            using (slmc db = new slmc())
            {
                var itemList = db.orderitem.Where(i => i.orderID.Equals(orderID)).Select(i => i);
                foreach (orderitem orderitem in itemList.ToList())
                {
                    item myItem = db.item.FirstOrDefault(i => i.itemID.Equals(orderitem.itemID));
                    myItem.orderedAmt -= orderitem.qty;
                    db.orderitem.Remove(orderitem);
                }
                db.SaveChanges();
            }
        }

        public static void AddOrderItems(int orderID, orderitem orderitem)
        {
            using (slmc db = new slmc())
            {
                order order = GetOrder(orderID);
                db.orderitem.Add(orderitem);

                staff dealer = Staffs.GetStaff(order.dealerID);

                // Update user's reserved amount of that item
                List<reserveditem> myReserved = Items.GetReservedItems(dealer);
                myReserved = myReserved.Where(i => i.itemID.Equals(orderitem.itemID) && i.availible.Equals("Y")).Select(i => i).ToList();
                int tmpQty = orderitem.qty;
                foreach(reserveditem item in myReserved)
                {
                    if (tmpQty <= 0)
                        break;

                    int reservedAmt = item.reservedAmt;
                    reservedAmt = reservedAmt - tmpQty;
                    if (reservedAmt <= 0)
                        Items.CancelReservation(item.reserveID);
                    else
                        Items.ModifyReservation(item.reserveID, reservedAmt);

                    tmpQty -= reservedAmt;
                }

                item myItem = db.item.FirstOrDefault(i => i.itemID.Equals(orderitem.itemID));
                myItem.orderedAmt += orderitem.qty;
                db.SaveChanges();
            }
        }

        public static void AddNewOrderItems(int orderID, orderitem orderitem)
        {
            using (slmc db = new slmc())
            {
                order order = GetOrder(orderID);
                db.orderitem.Add(orderitem);

                staff dealer = Staffs.GetStaff(order.dealerID);

                item myItem = db.item.FirstOrDefault(i => i.itemID.Equals(orderitem.itemID));
                myItem.orderedAmt += orderitem.qty;
                db.SaveChanges();
            }
        }

        public static int Add(order order)
        {
            using (slmc db = new slmc())
            {
                db.order.Add(order);
                db.SaveChanges();
                return order.orderID;
            }
        }

        public static void Add(order order, List<orderitem> orderitems)
        {
            using (slmc db = new slmc())
            {
                db.order.Add(order);
                db.SaveChanges();

                foreach (orderitem oi in orderitems)
                {
                    order.orderitem.Add(oi);
                }
                db.SaveChanges();
            }
        }

        public static void AddToDespatchNote(despatchnote despatchnote, order order)
        {
            using (slmc db = new slmc())
            {
                order myOrder = db.order.FirstOrDefault(i => i.orderID == order.orderID);
                myOrder.despatchID = despatchnote.despatchID;
                myOrder.statusID = OrderStatus.Assembled.statusID;
                db.SaveChanges();
            }
        }

        public static double GetOrderTotal(int orderID)
        {
            using (slmc db = new slmc())
            {
                order order = db.order.FirstOrDefault(i => i.orderID == orderID);
                double total = (order.orderitem.ToList().Select(i=>i.subTotal)).Sum();
                return total;
            }
        }

        public static int GetLatestOrderID(String dealerID)
        {
            using (slmc db = new slmc())
            {
                order order = db.order.OrderByDescending(i => i.orderID).FirstOrDefault(i => i.dealerID.Equals(dealerID));
                return order.orderID;
            }
        }
    }
}
