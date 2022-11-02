using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxCore.Models
{
    public abstract class APIResult
    {
        public bool result;
    }
    public class AddressBalance : APIResult
    {
        public string OXS;
        public string OXC;
    }
}
