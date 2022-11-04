/*
 * 全局变量
 */

var OXS = 1;
var OXC = 2;
var WalletName = "Wallet";
var ApiUrls = ["http://api.oxlink.us:10335", "http://api2.oxlink.us:10335", "http://api3.oxlink.us:10335",
	"http://api4.oxlink.us:10335", "http://api5.oxlink.us:10335"
]; //spv 节点地址
var MaxCutCount = 10; //调用出错次数最大值
var BottomTabIndex = 0; //底部菜單Index

//开始不可修改,重命名,

var mainbox;
//结束不可修改,重命名,

window.crypto = window.crypto || window.msCrypto; //for IE11
if (window.crypto.webkitSubtle) {
	window.crypto.subtle = window.crypto.webkitSubtle; //for Safari
}

var gtapp = {
	GetSeedUrl: function() {
		var index = parseInt(Math.random() * ApiUrls.length, 10);
		return ApiUrls[index];
	},
	GetApiUrl: function() {
		return gtapp.GetSeedUrl();
		// var nodesettings = appui.getNodes();
		// if ((!nodesettings.nodes) || (nodesettings.count > MaxCutCount)) {
		// 	var seedUrl = gtapp.GetSeedUrl();
		// 	gtapp.QueryNodes(seedUrl, function(data) {
		// 		nodesettings.nodes = data.nodes;
		// 		nodesettings.count = 0;
		// 		appui.setNodes(nodesettings);
		// 	}, function(error) {
		// 		//				alert(error);
		// 	});
		// 	//			alert(seedUrl);
		// 	return seedUrl;
		// } else {
		// 	var node;
		// 	mui.each(nodesettings.nodes, function(index, item) {
		// 		if (node) {
		// 			if (item.state < node.state)
		// 				node = item;
		// 		} else {
		// 			node = item;
		// 		}
		// 	});
		// 	if (node == null) return ""
		// 	else return node.url;
		// }
	},
	CutNode: function(UrlRoot) {
		var nodesettings = appui.getNodes();
		if (nodesettings) {
			mui.each(nodesettings.nodes, function(index, item) {
				if (item.url == UrlRoot) {
					item.state = item.state + 1;
				}
			});
			nodesettings.count = nodesettings.count + 1;
			appui.setNodes(nodesettings);
		}
	},
	QueryNodes: function(seedUrl, success, fail) {
		var url = seedUrl + "/api/getnodes?r=" + Math.random();;
		mui.ajax(url, {
			dataType: 'json', //服务器返回json格式数据
			type: 'get', //HTTP请求类型
			timeout: 10000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				success(data);
			},
			error: function(xhr, type, errorThrown) {
				fail(type);
			}
		});

	},
	GetMarkState: function() {
		return appui.getSettings().markstate;
	},
	SetMarkState: function(state) {
		var settings = appui.getSettings();
		settings.markstate = state;
		appui.setSettings(settings);
	},
	stripscript: function(s) {
		return s.replace(/<script.*?>.*?<\/script>/ig, '');
	},
	toLogin: function() {
		var loginPage = plus.webview.getWebviewById("login");
		if (!loginPage) {
			loginPage = mui.preload({
				"id": 'login',
				"url": '/login/login.html'
			});
			var id = setInterval(function() {
				clearInterval(id);
				mui.fire(loginPage, 'show', null);
				loginPage.show("pop-in");
			}, 20);
		} else {
			loginPage.show("pop-in");
		}

	},
	toUnlock: function() {
		var unlockPage = plus.webview.getWebviewById("unlock");

		if (!unlockPage) {
			unlockPage = mui.preload({
				"id": 'unlock',
				"url": '/login/unlock.html'
			});
			var id = setInterval(function() {
				clearInterval(id);
				mui.fire(unlockPage, 'show', null);
				unlockPage.show("pop-in");
			}, 20);
		} else {
			unlockPage.show("pop-in");
		}

	},
	toSetlock: function() {
		var handlockerPage = plus.webview.getWebviewById("handlocker");
		if (!handlockerPage) {
			handlockerPage = mui.preload({
				"id": 'handlocker',
				"url": '/login/handlocker.html'
			});
			var id = setInterval(function() {
				clearInterval(id);
				mui.fire(handlockerPage, 'show', null);
				handlockerPage.show("pop-in");
			}, 20);
		} else {
			handlockerPage.show("pop-in");
		}

	},
	WalletExist: function() {
		return GT.Wallets.Master.instance().then(function(result) {
			return result.get();
		}).then(function(result) {
			return result.indexOf(WalletName) >= 0;
		});
	},
	TryGetWallet: function(success) {
		var pwd = plus.navigator.getCookie('http://localhost');
		GT.Implementations.Wallets.IndexedDB.IndexedDBWallet.open(WalletName, pwd).then(function(result) {

			if (!result) //兼容IE
			{
				return;
			}
			GT.Global.Wallet = result;
			success(result);
		});
	},
	CreateWallet: function(pwd) {
		GT.Global.Wallet = GT.Implementations.Wallets.IndexedDB.IndexedDBWallet.create(WalletName, pwd);
		return GT.Global.Wallet;
	},
	PullHeight: function(success) {
		var urlroot = gtapp.GetApiUrl();
		var url = urlroot + "/api/height" + "?r=" + Math.random();
		mui.ajax(url, {
			dataType: 'json', //服务器返回json格式数据
			type: 'get', //HTTP请求类型
			timeout: 10000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				success(data);
			},
			error: function(xhr, type, errorThrown) {
				gtapp.CutNode(urlroot);
			}
		});
	},
	PullBalance: function(success) {
		var publicKey = GT.Global.Wallet.getAccounts()[0].publicKey.encodePoint(true).toHexString();
		gtapp.WalletExist().then(function(result) {
			if (result) {
				var urlroot = gtapp.GetApiUrl();
				var url = urlroot + "/api/balance" + "?publickey=" + publicKey + "&r=" + Math.random();

				mui.ajax(url, {
					dataType: 'json', //服务器返回json格式数据
					type: 'get', //HTTP请求类型
					timeout: 10000, //超时时间设置为10秒；
					headers: {
						'Content-Type': 'application/json'
					},
					success: function(data) {
						success(data);
					},
					error: function(xhr, type, errorThrown) {
						gtapp.CutNode(urlroot);
					}
				});
			}

		});
	},
	CheckDecimal: function(v) {
		var a = /^[0-9]*(\.[0-9]{1,8})?$/;
		if (!a.test(v)) {
			return false;
		} else {
			return true;
		}
	},
	PullClaim: function(address, success) {
		var urlroot = gtapp.GetApiUrl();
		var url = urlroot + "/api/claim" + "?ID=" + address + "&r=" + Math.random();
		mui.ajax(url, {
			dataType: 'json', //服务器返回json格式数据
			type: 'get', //HTTP请求类型
			timeout: 10000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				success(data);
			},
			error: function(xhr, type, errorThrown) {
				gtapp.CutNode(urlroot);
			}
		});
	},
	PullInRecords: function(address, pageindex, success) {
		var urlroot = gtapp.GetApiUrl();
		var url = urlroot + "/api/QueryTxIn" + "?address=" + address+"&pageIndex="+pageindex + "&r=" + Math.random();
		mui.ajax(url, {
			dataType: 'json', //服务器返回json格式数据
			type: 'get', //HTTP请求类型
			timeout: 10000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				success(data);
			},
			error: function(xhr, type, errorThrown) {
				gtapp.CutNode(urlroot);
			}
		});
	},
	PullOutRecords: function(address, pageindex, success) {
		var urlroot = gtapp.GetApiUrl();
		var url = urlroot + "/api/QueryTxOut" + "?address=" + address+"&pageIndex="+pageindex + "&r=" + Math.random();
		mui.ajax(url, {
			dataType: 'json', //服务器返回json格式数据
			type: 'get', //HTTP请求类型
			timeout: 10000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				success(data);
			},
			error: function(xhr, type, errorThrown) {
				gtapp.CutNode(urlroot);
			}
		});
	},
	Claim: function(success) {
		gtapp.PostClaim(function(resp) {
			if (resp.result) {
				var strTx = resp.transaction;
				var tx = GT.Core.Transaction.deserializeFrom(strTx.hexToBytes().buffer)
				if (gtapp.WalletExist()) {
					var publicKeyString = GT.Global.Wallet.getAccounts()[0].publicKey.encodePoint(true).toHexString();
					var account = GT.Global.Wallet.getAccounts()[0];
					GT.Global.Wallet.signInternal(tx, account).then(function(signature) {
						var sig = new Uint8Array(signature).toHexString();
						gtapp.BroadcastTransfer(2, publicKeyString, sig, strTx, function(resp) {
							success(resp);
						});
					});

				}
			}
		});

	},
	PostClaim: function(success) {
		var publicKey = GT.Global.Wallet.getAccounts()[0].publicKey.encodePoint(true).toHexString();
		gtapp.WalletExist().then(function(result) {
			if (result) {
				var urlroot = gtapp.GetApiUrl();
				var url = urlroot + "/api/Gas" + "?publicKey=" + publicKey + "&r=" + Math.random();
				mui.ajax(url, {
					dataType: 'json', //服务器返回json格式数据
					type: 'post', //HTTP请求类型
					timeout: 10000, //超时时间设置为10秒；
					headers: {
						'Content-Type': 'application/json'
					},
					success: function(data) {
						success(data);
					},
					error: function(xhr, type, errorThrown) {
						gtapp.CutNode(urlroot);
					}
				});
			}
		});
	},

	PostTransfer: function(source, dests, amounts, assetId, success) {
		var urlroot = gtapp.GetApiUrl();
		var url = urlroot + "/api/transfer";
		var params = [];
		params.push("source" + "=" + source);
		params.push("dests" + "=" + dests);
		params.push("amounts" + "=" + amounts);
		params.push("assetId" + "=" + assetId);
		var dataToSend = params.join("&");
		// mui.post(url, dataToSend, success, "json");
		var reqUrl = url + "?" + dataToSend.toString();
		mui.ajax(reqUrl, {
			// data: dataToSend,
			dataType: 'json', //服务器返回json格式数据
			type: 'get', //HTTP请求类型
			timeout: 10000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				success(data);
			},
			error: function(xhr, type, errorThrown) {
				//异常处理；
				gtapp.CutNode(urlroot);
			}
		});
	},
	BroadcastTransfer: function(txKind, pubKey, signature, tx, success) {
		var urlroot = gtapp.GetApiUrl();
		var url = urlroot + "/api/broadcast";
		var params = [];
		params.push("txkind" + "=" + txKind);
		params.push("publicKey" + "=" + pubKey);
		params.push("signature" + "=" + signature);
		params.push("transaction" + "=" + tx);
		var dataToSend = params.join("&");
		//		mui.post(url, dataToSend, success, "json");

		mui.ajax(url, {
			data: dataToSend,
			dataType: 'json', //服务器返回json格式数据
			type: 'post', //HTTP请求类型
			timeout: 10000, //超时时间设置为10秒；

			success: function(data) {
				success(data);
			},
			error: function(xhr, type, errorThrown) {
				//异常处理；
				gtapp.CutNode(urlroot);
			}
		});
	},
	Transfer: function(sourceAddress, destAddress, amt, assetId, success) {
		if (gtapp.CheckDecimal(amt) && sourceAddress) {
			gtapp.PostTransfer(sourceAddress, destAddress, amt, assetId, function(resp) {
				if (resp.result) {
					var strTx = resp.transaction;
					var tx = GT.Core.Transaction.deserializeFrom(strTx.hexToBytes().buffer)
					if (gtapp.WalletExist()) {
						var publicKeyString = GT.Global.Wallet.getAccounts()[0].publicKey.encodePoint(true).toHexString();
						var account = GT.Global.Wallet.getAccounts()[0];
						GT.Global.Wallet.signInternal(tx, account).then(function(signature) {
							var sig = new Uint8Array(signature).toHexString();
							gtapp.BroadcastTransfer(128, publicKeyString, sig, strTx, function(resp) {
								success(resp);
							});
						});

					}
				}
			});
		} else {
			plus.nativeUI.toast("转账金额的格式错误");
		}
	},
	PostJsonRPC: function(serveraddress, method, id, args, success, fail) {
		var params = [];
		params.push("jsonrpc=2.0");
		params.push("method" + "=" + method);
		params.push("id" + "=" + id);
		params.push("params" + "=" + args);
		var dataToSend = params.join("&");
		var url = serveraddress + '?' + dataToSend;
		mui.ajax(url, {
			type: 'get', //HTTP请求类型
			timeout: 10000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				success(data);
			},
			error: function(xhr, type, errorThrown) {
				fail(type);
			}
		});
	},
	GetHtml: function(url, success, fail) {
		mui.ajax(url, {
			type: 'get', //HTTP请求类型
			dataType: 'text',
			timeout: 10000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				success(data);
			},
			error: function(xhr, type, errorThrown) {
				fail(type);
			}
		});

	},
};
