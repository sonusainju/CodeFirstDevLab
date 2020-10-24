using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstDevLab.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }
        public string ProvinceCode { get; set; }

        [ForeignKey("ProvinceCode")]
        public Province Province { get; set; }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>() {
              new City {
                  CityId = 1,
                  CityName = "Regina",
                  Population = 180000,
                  ProvinceCode = "SK"
              },
              new City {
                  CityId = 2,
                  CityName = "Winnipeg",
                  Population = 500000,
                  ProvinceCode = "MB"
              },
              new City {
                  CityId = 3,
                  CityName = "Kelowna",
                  Population = 150000,
                  ProvinceCode = "BC"
              },
              new City {
                  CityId = 4,
                  CityName = "Calgary",
                  Population = 1000000,
                  ProvinceCode = "AB"
              }
          };
            return cities;
        }
    }
}
