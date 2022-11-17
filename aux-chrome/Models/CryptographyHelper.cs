using Blazored.SessionStorage;
using Blazored.LocalStorage;
using System.Threading.Tasks;
using OX;
using OX.Wallets;
using System;
using OX.Wallets.NEP6;
//using System.Security.Cryptography;
using OX.SmartContract;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
//using OX.Cryptography;
using System.Collections.Generic;
using System.Linq;

namespace auxchrome.Models
{
    public static class CryptographyHelper
    {
        [Inject]
        public static IJSRuntime JSRumtime { get; set; }      
       
    }
}
