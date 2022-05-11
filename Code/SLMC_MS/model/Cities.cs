using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class Cities
    {
        public static String GetCityID(String cityName)
        {
            using (slmc db = new slmc())
            {
                city city = db.city.FirstOrDefault(i => i.city1.Equals(cityName));
                if (city == null)
                    return null;
                else
                    return city.cityID;
            }
        }

        public static city GetCity(String cityID)
        {
            using (slmc db = new slmc())
            {
                city city = db.city.FirstOrDefault(i => i.cityID.Equals(cityID));
                return city;
            }
        }

        public static city GetCityByName(String cityName)
        {
            using (slmc db = new slmc())
            {
                city city = db.city.FirstOrDefault(i => i.city1.Equals(cityName));
                return city;
            }
        }

        public static province GetProvince(city city)
        {
            using (slmc db = new slmc())
            {
                var myProvince = db.province.FirstOrDefault(i => i.provinceID.Equals(city.provinceID));
                return myProvince;
            }
        }

        public static List<city> GetCities()
        {
            using (slmc db = new slmc())
            {
                return db.city.ToList();
            }
        }

        public static List<city> GetCities(province province)
        {
            using (slmc db = new slmc())
            {
                var cities = db.city.Where(i => i.provinceID.Equals(province.provinceID));
                return cities.ToList();
            }
        }

        public static double GetRevenue(String cityID, int month, int year)
        {
            using (slmc db = new slmc())
            {
                DateTime min = new DateTime(year, month, 1);
                DateTime max = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                var orders = from list in db.orderitem
                             where list.order.cityID.Equals(cityID) && list.order.orderDate >= min && list.order.orderDate <= max && 
                                   list.order.statusID.Equals("copl")
                             select list;
                if (orders != null)
                    return orders.ToList().Sum(i => i.subTotal);
                else
                    return 0;
            }
        }
    }
}
