using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class StaffPosition
    {
        public static readonly staffposition AreaManager = new staffposition { positionID = "AM", position = "Area Manager" };
        public static readonly staffposition DespatchClerk = new staffposition { positionID = "DC", position = "Despatch Clerk" };
        public static readonly staffposition Dealer = new staffposition { positionID = "DLR", position = "Dealer" };
        public static readonly staffposition GoodsInwardsClerk = new staffposition { positionID = "GIC", position = "GoodsInwardsClerk" };
        public static readonly staffposition SalesManager = new staffposition { positionID = "SM", position = "SalesManager" };
        public static readonly staffposition SalesOrderOfficeManager = new staffposition { positionID = "SOM", position = "Sales Order Office Manager" };
        public static readonly staffposition SalesOrderOfficer = new staffposition { positionID = "SOO", position = "Sales Order Officer" };
        public static readonly staffposition SparePartsController = new staffposition { positionID = "SPC", position = "Spare Parts Controller" };
        public static readonly staffposition StockRecordsClerk = new staffposition { positionID = "SRC", position = "Stock Records Clerk" };
        public static readonly staffposition Storemen = new staffposition { positionID = "STO", position = "Storemen" };

        public static List<staffposition> GetStaffpositions()
        {
            using (slmc db = new slmc())
            {
                var staffPositions = db.staffposition.Select(i => i);
                return staffPositions.ToList();
            }
        }

        public static staffposition GetStaffposition(String position)
        {
            using (slmc db = new slmc())
            {
                if (position.Length <= 3)
                {
                    staffposition staffposition = db.staffposition.FirstOrDefault(i => i.positionID.Equals(position));
                    return staffposition;
                }
                else
                {
                    staffposition staffposition = db.staffposition.FirstOrDefault(i => i.position.Equals(position));
                    return staffposition;
                }
            }
        }

        public static staffposition GetStaffposition(staff staff)
        {
            using (slmc db = new slmc())
            {
                staffposition staffPosition = db.staffposition.FirstOrDefault(i => i.positionID.Equals(staff.positionID));
                return staffPosition;
            }
        }
    }
}
