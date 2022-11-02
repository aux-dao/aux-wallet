using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OX;
using OX.Wallets;

namespace AuxCore
{
    public class LightAccount
    {
        public string ScriptHash { get; set; }
        private readonly string nep2key;
        private KeyPair key;
    }
}
