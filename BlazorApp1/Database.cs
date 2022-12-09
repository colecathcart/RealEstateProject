using System;
using System.Net;
using System.Collections.Generic;
using static BlazorApp1.House;
namespace BlazorApp1
{
    public static class Database
    {
        //public static List<String> selectedTypes = new List<string>();
        //public static List<String> selectedAmmenities = new List<string>();
        public static string test = "tester";
        public static List<House> houses = generateData();
        private static string[] properties = new string[] { "Single-Family", "Multi-Family", "Townhouse", "Apartment" };
        public static List<House> filtered = new List<House>();

        public static List<House> saved = new List<House>();

        private static List<House> generateData()
        {
            String[] perks = {"Heated garage","Walking-distance to train","Walking-distance to retail area","Borders on a green space","Master suite balcony","Air conditioning","En-suite bathroom","Community rec center",
            "Central location","Granite countertops","Nearby school","Nearby playground","Home security system","Walk-in closets","Heated flooring","Skylights"};
            List<House> data = new List<House>();
            data.Add(new House(1, "1700 University Drive NW", 200000.00, 800, 4, 4, "Single-Family", 1980, new String[] { "houseimages/house1.jpg", "houseimages/bathroom1.jpg", "houseimages/livingroom1.jpg", "houseimages/kitchen1.jpg" }, new DateTime(2022, 10, 05), new String[] {perks[0],perks[1],perks[2],perks[3]}));
            data.Add(new House(2, "2298 University Drive NW", 250000.00, 1000, 4, 4, "Single-Family", 1990, new String[] { "houseimages/house2.jpg", "houseimages/bathroom2.jpg", "houseimages/livingroom2.jpg", "houseimages/kitchen2.jpg" }, new DateTime(2022, 11, 06), new String[] { perks[4],perks[5],perks[6],perks[7] }));
            data.Add(new House(3, "4008 Pinewood Drive NE", 150000.00, 600, 1, 1, "Apartment", 2015, new String[] { "houseimages/apartment1.jpg", "houseimages/bathroom3.jpg", "houseimages/livingroom3.jpg", "houseimages/kitchen3.jpg" }, new DateTime(2022, 05, 25), new String[] { perks[8],perks[9],perks[10],perks[11] }));
            data.Add(new House(4, "1497 Shinn Avenue SW", 1200000.00, 2400, 6, 8, "Single-Family", 2020, new String[] { "houseimages/house3.jpg", "houseimages/bathroom4.jpg", "houseimages/livingroom4.jpg", "houseimages/kitchen4.jpg" }, new DateTime(2022, 11, 30), new String[] { perks[12],perks[13],perks[14],perks[15] }));
            data.Add(new House(5, "4778 Nelm Street SE", 550000.00, 1200, 5, 5, "Single-Family", 2018, new String[] { "houseimages/house4.jpg", "houseimages/bathroom5.jpg", "houseimages/livingroom5.jpg", "houseimages/kitchen5.jpg" }, new DateTime(2022, 08, 15), new String[] { perks[2],perks[4],perks[6],perks[8] }));
            data.Add(new House(6, "843 Meadowmall Road NW", 450000.00, 900, 3, 3, "Townhouse", 2016, new String[] { "houseimages/townhouse1.jpg", "houseimages/bathroom6.jpg", "houseimages/home-design.jpg", "houseimages/Photo-Home.jpg" }, new DateTime(2022, 01, 31), new String[] { perks[10],perks[12],perks[14],perks[15] }));
            data.Add(new House(7, "2367 Edsel Road NE", 750000.00, 1300, 5, 5, "Multi-Family", 2017, new String[] { "houseimages/townhouse2.jpg", "houseimages/bathroom1.jpg", "houseimages/livingroom1.jpg", "houseimages/kitchen6.jpg" }, new DateTime(2022, 03, 18), new String[] { perks[0],perks[3],perks[5],perks[7] }));
            data.Add(new House(8, "2963 Williams Lane SW", 100000.00, 600, 1, 1, "Apartment", 2008, new String[] { "houseimages/apartment2.jpg", "houseimages/bathroom3.jpg", "houseimages/livingroom4.jpg", "houseimages/kitchen7.jpg" }, new DateTime(2022, 09, 03), new String[] { perks[9],perks[11],perks[13],perks[15] }));
            data.Add(new House(9, "1788 Jarvisville Road SE", 500000.00, 1100, 4, 5, "Multi-Family", 2022, new String[] { "houseimages/house3.jpg", "houseimages/bathroom4.jpg", "houseimages/livingroom5.jpg", "houseimages/kitchen1.jpg" }, new DateTime(2022, 10, 31), new String[] { perks[0],perks[15],perks[1],perks[14] }));
            data.Add(new House(10, "4405 Williams Lane NW", 500000.00, 1000, 2, 3, "Townhouse", 2016, new String[] { "houseimages/townhouse3.jpg", "houseimages/bathroom2.jpg", "houseimages/livingroom2.jpg", "houseimages/kitchen4.jpg" }, new DateTime(2022, 02, 08), new String[] { perks[2],perks[13],perks[3],perks[12] }));
            data.Add(new House(11, "996 Arthur Avenue NE", 350000.00, 1500, 4, 5, "Single-Family", 2014, new String[] { "houseimages/house5.jpg", "houseimages/bathroom6.jpg", "houseimages/livingroom3.jpg", "houseimages/kitchen2.jpg" }, new DateTime(2022, 06, 19), new String[] { perks[4],perks[11],perks[5],perks[10] }));
            data.Add(new House(12, "2782 Oliver Street SW", 350000.00, 600, 2, 2, "Apartment", 2021, new String[] { "houseimages/apartment3.jpg", "houseimages/bathroom5.jpg", "houseimages/livingroom1.jpg", "houseimages/kitchen5.jpg" }, new DateTime(2022, 12, 03), new String[] { perks[6],perks[9],perks[7],perks[8] }));
            data.Add(new House(13, "1740 Fraggle Drive SE", 600000.00, 800, 3, 4, "Multi-Family", 2009, new String[] { "houseimages/house2.jpg", "houseimages/bathroom1.jpg", "houseimages/livingroom4.jpg", "houseimages/kitchen6.jpg" }, new DateTime(2022, 04, 23), new String[] { perks[8],perks[9],perks[6],perks[1] }));
            data.Add(new House(14, "4362 Boggess Street NW", 500000.00, 1200, 4, 5, "Single-Family", 2022, new String[] { "houseimages/house1.jpg", "houseimages/bathroom3.jpg", "houseimages/livingroom5.jpg", "houseimages/Photo-Home.jpg" }, new DateTime(2022, 11, 29), new String[] { perks[15],perks[0],perks[9],perks[3] }));
            data.Add(new House(15, "1513 Jody Road NE", 400000.00, 900, 2, 3, "Townhouse", 2020, new String[] { "houseimages/townhouse4.jpg", "houseimages/bathroom3.jpg", "houseimages/livingroom2.jpg", "houseimages/kitchen1.jpg" }, new DateTime(2022, 04, 08), new String[] { perks[2],perks[5],perks[8],perks[11] }));
            data.Add(new House(16, "4866 Lucy Lane SW", 1500000.00, 3500, 7, 8, "Single-Family", 2020, new String[] { "houseimages/house5.jpg", "houseimages/bathroom4.jpg", "houseimages/livingroom3.jpg", "houseimages/kitchen7.jpg" }, new DateTime(2022, 02, 19), new String[] { perks[10],perks[1],perks[13],perks[14] }));
            data.Add(new House(17, "154 Church Street SE", 150000.00, 900, 3, 3, "Apartment", 2021, new String[] { "houseimages/tower.jpg", "houseimages/condo.jpg", "houseimages/foyer.jpg", "houseimages/bathroom.jpg" }, new DateTime(2022, 08, 25), new String[] { perks[3],perks[15],perks[5],perks[9] }));
            data.Add(new House(18, "726 Cimmaron Road NW", 900000.00, 1200, 5, 6, "Multi-Family", 2015, new String[] { "houseimages/house5.jpg", "houseimages/bathroom6.jpg", "houseimages/livingroom1.jpg", "houseimages/kitchen3.jpg" }, new DateTime(2022, 01, 23), new String[] { perks[5],perks[9],perks[13],perks[1] }));
            data.Add(new House(19, "1201 Breezewood Court NE", 500000.00, 1100, 4, 5, "Townhouse", 2021, new String[] { "houseimages/townhouse1.jpg", "houseimages/bathroom2.jpg", "houseimages/livingroom4.jpg", "houseimages/kitchen3.jpg" }, new DateTime(2022, 12, 01), new String[] { perks[2],perks[6],perks[10],perks[14] }));
            data.Add(new House(20, "4116 Deercove Drive SW", 400000.00, 1000, 2, 3, "Townhouse", 2019, new String[] { "houseimages/townhouse2.jpg", "houseimages/bathroom5.jpg", "houseimages/livingroom5.jpg", "houseimages/kitchen2.jpg"  }, new DateTime(2022, 03, 15), new String[] { perks[3],perks[8],perks[10],perks[4] }));
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
            for (int i = 0; i < 20; i++)
            {
                if (Database.houses[i].Address == address)
                {
                    return Database.houses[i];
                }
            }
            return null;
        }

        public static List<House> searchByPrice(List<House> data, double? minPrice, double? maxPrice)
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
                if (data[i].Bathrooms >= bathr)
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
