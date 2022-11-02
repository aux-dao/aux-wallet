using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxCore.Models
{
    public static class Locator
    {
        public static bool ZH_CN()
        {
            return System.Globalization.CultureInfo.InstalledUICulture.Name.ToLower() == "zh-cn";
        }
        public static string Case(string En, string Cn)
        {
            return ZH_CN() ? Cn : En;
        }
    }
}
