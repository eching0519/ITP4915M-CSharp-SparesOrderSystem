using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class Suppliers
    {
        public static supplier GetSupplier(String supplierID)
        {
            using (slmc db = new slmc())
            {
                supplier mySupplier = db.supplier.FirstOrDefault(i => i.supplierID.Equals(supplierID));
                return mySupplier;
            }
        }

        public static List<supplier> GetSuppliers()
        {
            using (slmc db = new slmc())
            {
                var mySupplier = db.supplier.Select(i => i);
                return mySupplier.ToList();
            }
        }

        public static void Add(supplier supplier)
        {
            using (slmc db = new slmc())
            {
                db.supplier.Add(supplier);
                db.SaveChanges();
            }
        }

        public static List<item> GetItems(String supplierID)
        {
            using (slmc db = new slmc())
            {
                var items = db.item.Where(i => i.supplierID.Equals(supplierID));
                return items.ToList();
            }
        }

        public static void SetName(String supplierID, String supplierName)
        {
            using (slmc db = new slmc())
            {
                supplier mySupplier = db.supplier.FirstOrDefault(i => i.supplierID.Equals(supplierID));
                mySupplier.name = supplierName;
                db.SaveChanges();
            }
        }

        public static void SetAddress(String supplierID, String address)
        {
            using (slmc db = new slmc())
            {
                supplier mySupplier = db.supplier.FirstOrDefault(i => i.supplierID.Equals(supplierID));
                mySupplier.address = address;
                db.SaveChanges();
            }
        }
    }
}
