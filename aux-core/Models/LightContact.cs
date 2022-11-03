using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using OX;
using OX.IO.Json;
using OX.Network.P2P.Payloads;
using OX.Wallets;
using OX.Wallets.NEP6;
using OX.SmartContract;

namespace AuxCore
{
    public class LightContact
    {
        public UInt160 Address { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public LightContact(UInt160 address, string name, string remark)
        {
            this.Address = address;
            this.Name = name;
            this.Remark = remark;
        }
        public static LightContact FromJson(JObject json)
        {
            return new LightContact(json["address"].AsString().ToScriptHash(), json["name"]?.AsString(), json["remark"]?.AsString());
        }
        public JObject ToJson()
        {
            JObject account = new JObject();
            account["address"] = this.Address.ToAddress();
            account["name"] = this.Name;
            account["remark"] = this.Remark;
            return account;
        }
    }
}
