using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class Staffs
    {
        public static void Add(staff staff)
        {
            using (slmc db = new slmc())
            {
                db.staff.Add(staff);
                db.SaveChanges();
            }
        }

        public static void DisableStaffAccount(staff staff)
        {
            using (slmc db = new slmc())
            {
                user myUser = Users.GetUser(staff.staffID);
                myUser.disabled = "Y";
                db.SaveChanges();
            }
        }

        public static List<staff> GetStaffs()
        {
            using (slmc db = new slmc())
            {
                var staffs = db.staff.Select(i => i);
                return staffs.ToList();
            }
        }

        public static List<staff> SearchStaffs(String staffID, String name, String teamID, String position)
        {
            using (slmc db = new slmc())
            {
                String posID = "";
                if (position != "")
                {
                    if (teamID != "")
                    {
                        staffposition myPosition = StaffPosition.GetStaffposition(position);
                        posID = myPosition.positionID;
                        var myStaffs = db.staff.Where(i => i.staffID.Contains(staffID) && (i.name.Contains(name) || i.name_ch.Contains(name))
                                                    && i.teamID.Contains(teamID) && i.positionID.Equals(posID)).Select(i => i);
                        return myStaffs.ToList();
                    }
                    else
                    {
                        staffposition myPosition = StaffPosition.GetStaffposition(position);
                        posID = myPosition.positionID;
                        var myStaffs = db.staff.Where(i => i.staffID.Contains(staffID) && (i.name.Contains(name) || i.name_ch.Contains(name))
                                                    && i.positionID.Equals(posID)).Select(i => i);
                        return myStaffs.ToList();
                    }
                }
                else
                {
                    if (teamID != "")
                    {
                        var staffs = db.staff.Where(i => i.staffID.Contains(staffID) && (i.name.Contains(name) || i.name_ch.Contains(name))
                                                && i.teamID.Contains(teamID)).Select(i => i);
                        return staffs.ToList();
                    }
                    else
                    {
                        var staffs = db.staff.Where(i => i.staffID.Contains(staffID) && (i.name.Contains(name) || i.name_ch.Contains(name))).Select(i => i);
                        return staffs.ToList();
                    }
                }
            }
        }

        public static List<staff> GetStaffs(team team)
        {
            using (slmc db = new slmc())
            {
                var staffs = db.staff.Where(i => i.teamID.Equals(team.teamID)).Select(i => i);
                return staffs.ToList();
            }
        }

        public static staff GetStaff(String myStaffID)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(myStaffID));
                return myStaff;
            }
        }

        public static List<reserveditem> GetReserveditems(staff myStaff)
        {
            using (slmc db = new slmc())
            {
                var myReserved = db.reserveditem.Where(i => i.dealerID.Equals(myStaff.staffID)).Select(i => i);
                return myReserved.ToList();
            }
        }

        //public static reserveditem GetAvailableReserveditem(staff staff,String itemID)
        //{
        //    using (slmc db = new slmc())
        //    {
        //        var myReserved = db.reserveditem.FirstOrDefault(i => i.dealerID.Equals(staff.staffID) && i.availible.Equals("Y") && i.itemID.Equals(itemID));
        //        return myReserved;
        //    }
        //}

        public static void ReduceReservedItem(staff staff, String itemID, int reduceQty)
        {
            using (slmc db = new slmc())
            {
                var myReserved = db.reserveditem.FirstOrDefault(i => i.dealerID.Equals(staff.staffID) && i.availible.Equals("Y") && i.itemID.Equals(itemID));
                if (myReserved == null)
                    return;
                myReserved.reservedAmt -= reduceQty;
                if(myReserved.reservedAmt<=0)
                {
                    db.reserveditem.Remove(myReserved);
                }
                db.SaveChanges();
            }
        }

        public static void AddReservedItem(staff staff, String itemID, int addQty)
        {
            using (slmc db = new slmc())
            {
                var myReserved = db.reserveditem.FirstOrDefault(i => i.dealerID.Equals(staff.staffID) && i.availible.Equals("N") && i.itemID.Equals(itemID));
                if (myReserved == null)
                {
                    reserveditem reserveditems = new reserveditem
                    {
                        dealerID = staff.staffID,
                        itemID = itemID,
                        reservedAmt = addQty,
                        availible = "N"
                    };
                    db.reserveditem.Add(reserveditems);
                }
                else
                {
                    myReserved.reservedAmt += addQty;
                }
                db.SaveChanges();
            }
        }

        public static bool isDealer(staff staff)
        {
            return staff.positionID.Equals("DLR");
        }

        public static bool isAreaManager(staff staff)
        {
            return staff.positionID.Equals("AM");
        }

        public static bool isDespatchClerk(staff staff)
        {
            return staff.positionID.Equals("DC");
        }

        public static bool isGoodsInwardsClerk(staff staff)
        {
            return staff.positionID.Equals("GIC");
        }

        public static bool isSalesManager(staff staff)
        {
            try
            {
                return staff.positionID.Equals("SM");
            } catch(Exception exp)
            {
                return false;
            }
        }

        public static bool isSalesOrderOfficeManager(staff staff)
        {
            return staff.positionID.Equals("SOM");
        }

        public static bool isSalesOrderOfficer(staff staff)
        {
            return staff.positionID.Equals("SOO");
        }

        public static bool isSparePartsController(staff staff)
        {
            return staff.positionID.Equals("SPC");
        }

        public static bool isStockRecordsClerk(staff staff)
        {
            return staff.positionID.Equals("SRC");
        }

        public static bool isStoremen(staff staff)
        {
            return staff.positionID.Equals("STO");
        }

        public static city GetCity(staff staff)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(staff.staffID));
                if (myStaff != null)
                    return db.city.FirstOrDefault(i => i.cityID.Equals(myStaff.cityID));
                else
                    return null;
            }
        }

        public static void SetName(String staffID, String name)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(staffID));
                myStaff.name = name;
                db.SaveChanges();
            }
        }

        public static void SetName_ch(String staffID, String name_ch)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(staffID));
                myStaff.name_ch = name_ch;
                db.SaveChanges();
            }
        }

        public static void SetPosition(String staffID, String position)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(staffID));
                myStaff.positionID = StaffPosition.GetStaffposition(position).positionID;
                db.SaveChanges();
            }
        }

        public static staffposition GetPosition(staff staff)
        {
            using (slmc db = new slmc())
            {
                staffposition position = db.staffposition.FirstOrDefault(i => i.positionID.Equals(staff.positionID));
                if (position != null)
                    return position;
                else
                    return null;
            }
        }

        public static void SetTeam(String staffID, String teamID)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(staffID));
                if (teamID == "")
                    myStaff.teamID = null;
                else
                    myStaff.teamID = teamID;
                db.SaveChanges();
            }
        }

        public static void SetAddress(String staffID, String cityName, String address)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(staffID));
                myStaff.cityID = Cities.GetCityID(cityName);
                myStaff.address = address;
                db.SaveChanges();
            }
        }

        public static String GetStaffName(String staffID)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(staffID));
                return myStaff.name;
            }
        }
    }
}
