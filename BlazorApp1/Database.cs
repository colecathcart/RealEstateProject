using System;
using System.Net;
using System.Collections.Generic;
using static BlazorApp1.House;
namespace BlazorApp1
{
    public static class Database
    {
        public static List<House> houses = generateData();
        private static string[] properties = new string[] { "Single-Family", "Multi-Family", "Townhouse", "Apartment" };

        private static List<House> generateData()
        {
            List<House> data = new List<House>();
            data.Add(new House(1, "Address #1", 200000.00, 800, 4, 4, "Single-Family", 1980, new String[] { "img1.png", "img2.png", "img3.png", "img4.png" }, new DateTime(2022, 10, 05), new String[] {"Perk #1, Perk #2, Perk #3, Perk #4"}));
            data.Add(new House(2, "Address #2", 250000.00, 1000, 4, 4, "Single-Family", 1990, new String[] { "img5.png", "img6.png", "img7.png", "img8.png" }, new DateTime(2022, 11, 06), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(3, "Address #3", 150000.00, 600, 1, 1, "Apartment", 2015, new String[] { "img9.png", "img10.png", "img11.png", "img12.png" }, new DateTime(2022, 05, 25), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(4, "Address #4", 1200000.00, 2400, 6, 8, "Single-Family", 2020, new String[] { "img13.png", "img14.png", "img15.png", "img16.png" }, new DateTime(2022, 11, 30), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(5, "Address #5", 550000.00, 1200, 5, 5, "Single-Family", 2018, new String[] { "img17.png", "img18.png", "img19.png", "img20.png" }, new DateTime(2022, 08, 15), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(6, "Address #6", 450000.00, 900, 3, 3, "Townhouse", 2016, new String[] { "img21.png", "img22.png", "img23.png", "img24.png" }, new DateTime(2022, 01, 31), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(7, "Address #7", 750000.00, 1300, 5, 5, "Multi-Family", 2017, new String[] { "img25.png", "img26.png", "img27.png", "img28.png" }, new DateTime(2022, 03, 18), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(8, "Address #8", 100000.00, 600, 1, 1, "Apartment", 2008, new String[] { "img29.png", "img30.png", "img31.png", "img32.png" }, new DateTime(2022, 09, 03), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(9, "Address #9", 500000.00, 1100, 4, 5, "Multi-Family", 2022, new String[] { "img33.png", "img34.png", "img35.png", "img36.png" }, new DateTime(2022, 10, 31), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(10, "Address #10", 500000.00, 1000, 2, 3, "Townhouse", 2016, new String[] { "img37.png", "img38.png", "img39.png", "img40.png" }, new DateTime(2022, 02, 08), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(11, "Address #11", 350000.00, 1500, 4, 5, "Single-Family", 2014, new String[] { "img41.png", "img42.png", "img43.png", "img44.png" }, new DateTime(2022, 06, 19), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(12, "Address #12", 350000.00, 600, 2, 2, "Apartment", 2021, new String[] { "img45.png", "img46.png", "img47.png", "img48.png" }, new DateTime(2022, 12, 03), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(13, "Address #13", 600000.00, 800, 3, 4, "Multi-Family", 2009, new String[] { "img49.png", "img50.png", "img51.png", "img52.png" }, new DateTime(2022, 04, 23), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(14, "Address #14", 500000.00, 1200, 4, 5, "Single-Family", 2022, new String[] { "img53.png", "img54.png", "img55.png", "img56.png" }, new DateTime(2022, 11, 29), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(15, "Address #15", 400000.00, 900, 2, 3, "Townhouse", 2020, new String[] { "img57.png", "img58.png", "img59.png", "img60.png" }, new DateTime(2022, 04, 08), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(16, "Address #16", 1500000.00, 3500, 7, 8, "Single-Family", 2020, new String[] { "img61.png", "img62.png", "img63.png", "img64.png" }, new DateTime(2022, 02, 19), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(17, "Address #17", 150000.00, 900, 3, 3, "Apartment", 2021, new String[] { "img65.png", "img66.png", "img67.png", "img68.png" }, new DateTime(2022, 08, 25), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(18, "Address #18", 900000.00, 1200, 5, 6, "Multi-Family", 2015, new String[] { "img69.png", "img70.png", "img71.png", "img72.png" }, new DateTime(2022, 01, 23), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(19, "Address #19", 500000.00, 1100, 4, 5, "Townhouse", 2021, new String[] { "img73.png", "img74.png", "img75.png", "img76.png" }, new DateTime(2022, 12, 01), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            data.Add(new House(20, "Address #20", 400000.00, 1000, 2, 3, "Townhouse", 2019, new String[] { "img77.png", "img78.png", "img79.png", "img80.png" }, new DateTime(2022, 03, 15), new String[] { "Perk #1, Perk #2, Perk #3, Perk #4" }));
            return data;
        }

        private static string randomPropertyType()
        {
            Random rand = new Random();
            int index = rand.Next(0, 4);
            return Database.properties[index];

        }

        public static House searchByAddress(string address)
        { 
            for (int i=0; i< 20; i++)
            {
                if (Database.houses[i].Address == address)
                {
                    return Database.houses[i];
                } 
            }
            return null;
        }

        public static List<House> searchByPrice(List<House> data, double minPrice, double maxPrice)
        {
            if (data.Count == 0)
            {
                data = Database.houses;
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

        public static List<House> searchBySquareFootage(List<House> data, int sq)
        {
            if (data.Count == 0)
            {
                data = Database.houses;
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

        public static List<House> searchByBedrooms(List<House> data, int bd)
        {
            if (data.Count == 0)
            {
                data = Database.houses;
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

        public static List<House> searchByBathrooms(List<House> data, int bathr)
        {
            if (data.Count == 0)
            {
                data = Database.houses;
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

        public static List<House> searchByPropertyType(List<House> data, string pt)
        {
            if (data.Count == 0)
            {
                data = Database.houses;
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

        public static List<House> searchByYearBuilt(List<House> data, int yb)
        {
            if (data.Count == 0)
            {
                data = Database.houses;
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

