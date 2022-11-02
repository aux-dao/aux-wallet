using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxCore.Models
{
    public static class Locator
    {
        public static string[] spvlidators = new string[]
      { "0227e102c5963a4c839b22019909a2ed5f0d2b5a26790e093631af9e5009b116d8",
            "02cc41d5831c5779c2dcdac03f193ec700188e5e62c306491ba9f179ba1a3c1bf1",
            "0270ce7a782105f80c104e52810611426b6389ff562c10a3ad225ccb89eb9fc467",
            "03fb6dbf055506f33ba07896518b9d368db45048a5e7ca21ce729fdcab01e8b546",
            "0338a9ee5f235dcdce7b4fd588edbc05db111114944e6f247420e05d21ce281e2f",
            "030be71ae4692e0a26f898cc32d7546d872ff4ebe91c2c9b26c3d43ce3d3bcc0d0",
            "0256f4a7c913f1630fec4e6220c8afca8cc5975723dd695f53571314dda8738806" };
        public static string[] ApiUrls = new string[]
            { "http://api.oxlink.us:10335",
                "http://api2.oxlink.us:10335",
                "http://api3.oxlink.us:10335",
                "http://api4.oxlink.us:10335",
                "http://api5.oxlink.us:10335"};
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
