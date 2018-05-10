using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalwcf
{
    public class addy2
    {
        public static List<addy> db = new List<addy>();
        
        public static List<string> showe1 = new List<string>();
        public static List<string> showe2 = new List<string>();
        public static List<string> showe3 = new List<string>();
        public static List<string> showe4 = new List<string>();
        public static List<string> showe5 = new List<string>();

        public void deletpp(int index)
        {
            db.RemoveAt(index);

        }
        public void update(int index, string bus, string capac)
        {
            addy a = new addy();
            a = db.ElementAt(index);
            a.Bus = bus;
            a.Capacity = capac;

        }

    }
}