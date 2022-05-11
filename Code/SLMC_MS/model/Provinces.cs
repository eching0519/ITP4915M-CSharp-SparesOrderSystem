using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class Provinces:province
    {
        public static List<province> GetProvinces()
        {
            using (slmc db = new slmc())
            {
                var provinces = db.province.Select(i => i);
                return provinces.ToList();
            }
        }

        public static province GetProvince(String provinceName)
        {
            using (slmc db = new slmc())
            {
                province province = db.province.FirstOrDefault(i => i.province1.Equals(provinceName));
                return province;
            }
        }

        public static province GetProvince(city city)
        {
            using (slmc db = new slmc())
            {
                province province = db.province.FirstOrDefault(i => i.provinceID.Equals(city.provinceID));
                return province;
            }
        }

        public static province GetProvinceById(String provinceID)
        {
            using (slmc db = new slmc())
            {
                province province = db.province.FirstOrDefault(i => i.provinceID.Equals(provinceID));
                return province;
            }
        }
    }
}
