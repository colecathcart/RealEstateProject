using System;
using static System.Net.Mime.MediaTypeNames;

namespace BlazorApp1
{
    public static class Tester
    {
        //public static List<string> propertyTypes = new List<string>();
        public static String test { get; set; }
        public static void setTest(String test1)
        {
            test = test1;
        }
        public static String getTest()
        {
            return test;
        }
    }


}

