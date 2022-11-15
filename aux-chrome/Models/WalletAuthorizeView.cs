using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using OX;

namespace auxchrome.Models
{
    public class WalletAuthorizeView : ComponentBase
    {
        ChromeWallet Wallet;
        [Parameter]
        public RenderFragment<ChromeWallet>? NotAuthorized { get; set; }

        [Parameter]
        public RenderFragment<ChromeWallet>? Authorized { get; set; }

        [Inject]
        Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [Inject]
        Blazored.LocalStorage.ISyncLocalStorageService localStorage { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (this.Wallet.IsNotNull())
            {
                builder.AddContent(0, Authorized?.Invoke(this.Wallet));
            }
            else
            {
                builder.AddContent(0, NotAuthorized?.Invoke(this.Wallet));
            }
        }

        protected override void OnParametersSet()
        {
            this.Wallet = this.sessionStorage.GetWallet();
        }
    }
}
