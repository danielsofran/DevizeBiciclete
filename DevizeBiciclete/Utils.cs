﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevizeBiciclete
{
    public static class Utils
    {
        public static bool Egal(this string s1, string s2)
        {
            if (s1 is null) return true;
            if (s2 is null) return true;
            return s1.Equals(s2);
        }

        public static bool Egal(this DateTime d1, DateTime d2)
        {
            return d1.Day == d2.Day && d1.Month == d2.Month && d1.Year == d2.Year;
        }

        public static string Afis(this DateTime d) => string.Format("{0}.{1}.{2}", d.Year, d.Month, d.Day);
        public static DateTime FormatDate(string txt)
        {
            if (txt == null) return DateTime.MinValue;
            string[] tokens = txt.Split('.');
            DateTime dt = new DateTime(int.Parse(tokens[0]), int.Parse(tokens[1]), int.Parse(tokens[2]));
            return dt;
        }
    }
}