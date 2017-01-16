using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Helpers
{
    public class Bootstrap
    {
        public const string BundleBase = "~/Content/css/";

        public class Theme
        {
            public const string Stock = "Stock";
            public const string Amelia = "Amelia";
            public const string Darkly = "Darkly";
            public const string Cerulean = "Cerulean";
        }

        public static HashSet<string> Themes = new HashSet<string>
        {
            Theme.Stock,
            Theme.Amelia,
            Theme.Darkly,
            Theme.Cerulean
        };

        public static string Bundle(string themename)
        {
            return BundleBase + themename;
        }
    }
}