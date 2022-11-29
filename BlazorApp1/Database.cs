using System;
using System.Net;
using System.Collections.Generic;
using static BlazorApp1.House;
namespace BlazorApp1
{
    public class Database
    {
        public List<House> houses { get; set; }
        private static string[] properties = new string[] { "Single-Family", "Multi-Family", "Townhouse", "Apartment" };

        public Database()
        {
            houses = generateData();
        }

        private static List<House> generateData()
        {
            List<House> data = new List<House>();
            Random rand = new Random();
            int j = 0;
            for (int i = 0; i < 20; i++)
            {
                string address = "Address #" + i;
                double price = rand.NextDouble() * 1000000;
                int sf = rand.Next(800, 2400);
                int br = rand.Next(1, 5);
                int bathr = rand.Next(1, 5);
                string pt = Database.randomPropertyType();
                int yb = rand.Next(1980, 2023);
                String[] imgs = new string[4];
                for (int k=0; k<4; k++)
                {
                    imgs[k] = "img_" + j + ".png";
                    j += 1;
                }
                House house = new House(i, address, price, sf, br, bathr, pt, yb, imgs);
                data.Add(house);
            }
            return data;
        }

        private static string randomPropertyType()
        {
            Random rand = new Random();
            int index = rand.Next(0, 4);
            return Database.properties[index];

        }

        public House searchByAddress(string address)
        { 
            for (int i=0; i< 20; i++)
            {
                if (houses[i].Address == address)
                {
                    return houses[i];
                } 
            }
            return null;
        }

        public List<House> searchByPrice(List<House> data, double minPrice, double maxPrice)
        {
            if (data.Count == 0)
            {
                data = houses;
            }
            List<House> filteredData = new List<House>();
            for (int i = 0; i < data.Count; i++)
            {
                if (minPrice <= data[i].Price && maxPrice >= data[i].Price)
                {
                    filteredData.Add(data[i]);
                }
            }
            return filteredData;
        }

        public List<House> searchBySquareFootage(List<House> data, int sq)
        {
            if (data.Count == 0)
            {
                data = houses;
            }
            List<House> filteredData = new List<House>();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].SquareFootage >= sq)
                {
                    filteredData.Add(data[i]);
                }
            }
            return filteredData;
        }

        public List<House> searchByBedrooms(List<House> data, int bd)
        {
            if (data.Count == 0)
            {
                data = houses;
            }
            List<House> filteredData = new List<House>();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Bedrooms >= bd)
                {
                    filteredData.Add(data[i]);
                }
            }
            return filteredData;
        }

        public List<House> searchByBathrooms(List<House> data, int bathr)
        {
            if (data.Count == 0)
            {
                data = houses;
            }
            List<House> filteredData = new List<House>();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Bathrooms > bathr)
                {
                    filteredData.Add(data[i]);
                }
            }
            return filteredData;
        }

        public List<House> searchByPropertyType(List<House> data, string pt)
        {
            if (data.Count == 0)
            {
                data = houses;
            }
            List<House> filteredData = new List<House>();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].PropertyType == pt)
                {
                    filteredData.Add(data[i]);
                }
            }
            return filteredData;
        }

        public List<House> searchByYearBuilt(List<House> data, int yb)
        {
            if (data.Count == 0)
            {
                data = houses;
            }
            List<House> filteredData = new List<House>();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].YearBuilt == yb)
                {
                    filteredData.Add(data[i]);
                }
            }
            return filteredData;
        }
    }
}

