//window.CreateOXWallet = () => {
//if (gtapp.CreateWallet('123')) {
//    GT.Wallets.Master.instance().then(function (result) {
//        result.add(WalletName);
//        localStorage.setItem("walletname", WalletName);
//        return result.WalletName;
//    });
//}
//};
export function showPrompt(message) {
    if (gtapp.CreateWallet('123')) {
        GT.Wallets.Master.instance().then(function (result) {
            result.add(WalletName);
            localStorage.setItem("walletname", WalletName);
            return result.WalletName;
        });
    }
    //return prompt(message, 'Type anything here');
}