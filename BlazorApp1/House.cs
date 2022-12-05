using System;
using System.Drawing;
namespace BlazorApp1
{
    public class House
    {
        public int id { get; set; }
        public string Address { get; set; }
        public double? Price { get; set; }
        public int SquareFootage { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public string PropertyType { get; set; }
        public int YearBuilt { get; set; }
        public String[] images { get; set; }
        public DateTime listDate { get; set; }
        public String[] perks { get; set; }

        public House(int id, string address, double? price, int sf, int br, int bathr, string pt, int yb, String[] imgs, DateTime ld, String[] p)
        {
            this.Address = address;
            this.Price = price;
            this.SquareFootage = sf;
            this.Bedrooms = br;
            this.Bathrooms = bathr;
            this.PropertyType = pt;
            this.YearBuilt = yb;
            this.images = imgs;
            this.listDate = ld;
            this.perks = p;
        }

    }
}
