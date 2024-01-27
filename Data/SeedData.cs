using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityProvince.Models;
using Microsoft.EntityFrameworkCore;

namespace CityProvinceMvc.Data;

public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }

    
    public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>() {
            new Province {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia",
            },
            new Province {
                ProvinceCode = "AB",
                ProvinceName = "Alberta",
            },
            new Province {
                ProvinceCode = "ON",
                ProvinceName = "Ontario",
            },
        };

        return provinces;
    }
    public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City() {    // 1
                CityId = 1,
                CityName = "Vancouver",
                Population = 675218,
                ProvinceCode = "BC",
            },
            new City() {
                CityId = 2,
                CityName = "Surrey",
                Population = 518467,
                ProvinceCode = "BC",
            },
            new City() {
                CityId = 3,
                CityName = "Burnaby",
                Population = 249197,
                ProvinceCode = "BC",
            },
            new City() {
                CityId = 4,
                CityName = "Calgary",
                Population = 1237656,
                ProvinceCode = "AB",
            },
            new City() {
                CityId = 5,
                CityName = "Edmonton",
                Population = 981280,
                ProvinceCode = "AB",
            },
            new City() {
                CityId = 6,
                CityName = "Red Deer",
                Population = 100418,
                ProvinceCode = "AB",
            },
            new City() {
                CityId = 7,
                CityName = "Toronto",
                Population = 2731571,
                ProvinceCode = "ON",
            },
            new City() {
                CityId = 8,
                CityName = "Ottawa",
                Population = 964743,
                ProvinceCode = "ON",
            },
            new City() {
                CityId = 9,
                CityName = "Mississauga",
                Population = 721599,
                ProvinceCode = "ON",
            },
        };

        return cities;
    }

}