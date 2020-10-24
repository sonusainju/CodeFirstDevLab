﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstDevLab.Models;

namespace CodeFirstDevLab.Data
{
    public static class DummyData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                Province.GetProvinces()
            );
            modelBuilder.Entity<City>().HasData(
                City.GetCities()
            );
        }
    }
}
