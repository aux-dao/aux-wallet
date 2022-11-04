/*
 * 全局变量
 */

var OXS = 1;
var OXC = 2;
var WalletName = "Wallet";
var spvlidators = ["0227e102c5963a4c839b22019909a2ed5f0d2b5a26790e093631af9e5009b116d8",
	"02cc41d5831c5779c2dcdac03f193ec700188e5e62c306491ba9f179ba1a3c1bf1",
	"0270ce7a782105f80c104e52810611426b6389ff562c10a3ad225ccb89eb9fc467",
	"03fb6dbf055506f33ba07896518b9d368db45048a5e7ca21ce729fdcab01e8b546",
	"0338a9ee5f235dcdce7b4fd588edbc05db111114944e6f247420e05d21ce281e2f",
	"030be71ae4692e0a26f898cc32d7546d872ff4ebe91c2c9b26c3d43ce3d3bcc0d0",
	"0256f4a7c913f1630fec4e6220c8afca8cc5975723dd695f53571314dda8738806"
];
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
		// return gtapp.GetSeedUrl();
		var url = appui.getCurrentSpv();
		return url;
	},
	CutNode: function(UrlRoot) {
		var ns = appui.getSpvs();
		if (!ns) {
			ns = new Array();
		}
		var spvUrls = ApiUrls.concat(ns);
		var spvUrl = spvUrls[Math.floor(Math.random() * spvUrls.length)];
		appui.setCurrentSpv(spvUrl);
	},
	VerifySpv: function(newUrl, success, fail) {
		var d = new Date();
		var dt = d.getFullYear().toString() + d.getMonth().toString() + d.getDate().toString() + Math.random().toString() +
			Math.random().toString();
		var uarry = new Uint8Array(gtapp.stringToByte(dt));
		var rd = uarry.toHexString();
		// console.log(rd);
		var url = newUrl + "/api/VerifySpv?rd=" + rd;
		mui.ajax(url, {
			dataType: 'json', //服务器返回json格式数据
			type: 'get', //HTTP请求类型
			timeout: 10000, //超时时间设置为10秒；
			headers: {
				'Content-Type': 'application/json'
			},
			success: function(data) {
				// alert(JSON.stringify(data));
				if (spvlidators.indexOf(data.pubkey) >= 0 && gtapp.verifyByPublicKey(rd.hexToBytes(), data.signature.hexToBytes(),
						data.pubkey)) {
					success(true);
				} else {
					success(false);
				}
			},
			error: function(xhr, type, errorThrown) {
				fail(type);
			}
		});

	},
	stringToByte: function(str) {
		const utf8 = [];
		for (let ii = 0; ii < str.length; ii++) {
			let charCode = str.charCodeAt(ii);
			if (charCode < 0x80) utf8.push(charCode);
			else if (charCode < 0x800) {
				utf8.push(0xc0 | (charCode >> 6), 0x80 | (charCode & 0x3f));
			} else if (charCode < 0xd800 || charCode >= 0xe000) {
				utf8.push(0xe0 | (charCode >> 12), 0x80 | ((charCode >> 6) & 0x3f), 0x80 | (charCode & 0x3f));
			} else {
				ii++;
				// Surrogate pair:
				// UTF-16 encodes 0x10000-0x10FFFF by subtracting 0x10000 and
				// splitting the 20 bits of 0x0-0xFFFFF into two halves
				charCode = 0x10000 + (((charCode & 0x3ff) << 10) | (str.charCodeAt(ii) & 0x3ff));
				utf8.push(
					0xf0 | (charCode >> 18),
					0x80 | ((charCode >> 12) & 0x3f),
					0x80 | ((charCode >> 6) & 0x3f),
					0x80 | (charCode & 0x3f),
				);
			}
		}
		//兼容汉字，ASCII码表最大的值为127，大于127的值为特殊字符
		for (let jj = 0; jj < utf8.length; jj++) {
			var code = utf8[jj];
			if (code > 127) {
				utf8[jj] = code - 256;
			}
		}
		return utf8;

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
	VerifyApi: function() {
		var pubkeyString = '';
		var pubKey = GT.Cryptography.ECPoint.parse(pubkeyString, GT.Cryptography.ECCurve.secp256r1);
	},
	verifyByPublicKey: function(message, signature, publicKeyStr) {
		var pubKey = GT.Cryptography.ECPoint.parse(publicKeyStr, GT.Cryptography.ECCurve.secp256r1);
		var arr = Uint8Array.fromArrayBuffer(signature);
		var r = GT.BigInteger.fromUint8Array(arr.subarray(0, 32), 1, false);
		var s = GT.BigInteger.fromUint8Array(arr.subarray(32, 64), 1, false);
		if (r.compareTo(pubKey.curve.N) >= 0 || s.compareTo(pubKey.curve.N) >= 0)
			return false;
		var e = GT.Cryptography.ECDsa.calculateE(pubKey.curve.N, message);
		var c = s.modInverse(pubKey.curve.N);
		var u1 = e.multiply(c).mod(pubKey.curve.N);
		var u2 = r.multiply(c).mod(pubKey.curve.N);
		var point = GT.Cryptography.ECDsa.sumOfTwoMultiplies(pubKey.curve.G, u1, pubKey, u2);
		var v = point.x.value.mod(pubKey.curve.N);
		return v.equals(r);
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
	PullBalanceByAddress: function(address, success) {
		var urlroot = gtapp.GetApiUrl();
		var url = urlroot + "/api/balancebyaddress" + "?address=" + address + "&r=" + Math.random();
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
		var url = urlroot + "/api/claim" + "?id=" + address + "&r=" + Math.random();
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
	PullTxDetail: function(txid,success) {
		var urlroot = gtapp.GetApiUrl();
		var url = urlroot + "/api/GetTx" + "?txid=" + txid + "&r=" + Math.random();
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
		var url = urlroot + "/api/QueryTxIn" + "?address=" + address + "&pageIndex=" + pageindex + "&r=" + Math.random();
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
		var url = urlroot + "/api/QueryTxOut" + "?address=" + address + "&pageIndex=" + pageindex + "&r=" + Math.random();
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
	PullSwapRecords: function(kind, address, pageindex, success) {
		var urlroot = gtapp.GetApiUrl();
		var url = urlroot + "/api/QuerySwapRecord" + "?kind=" + kind + "&address=" + address + "&pageIndex=" + pageindex +
			"&r=" + Math.random();
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
				if (spvlidators.indexOf(resp.pubkey) >= 0 && gtapp.verifyByPublicKey(strTx.hexToBytes(), resp.signature.hexToBytes(),
						resp.pubkey)) {
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
				} else {
					alert("交易打包无效");
				}
			}
		});
	},
	PostClaim: function(success) {
		var publicKey = GT.Global.Wallet.getAccounts()[0].publicKey.encodePoint(true).toHexString();
		// alert(publicKey);
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
	GetSwapEth: function(success) {
		gtapp.RequestSwapAccount(function(resp) {
			if (resp.result) {
				var strAdrs = resp.accounts;
				var datas = strAdrs.hexToBytes();
				if (spvlidators.indexOf(resp.pubkey) >= 0 && gtapp.verifyByPublicKey(datas, resp.signature.hexToBytes(),
						resp.pubkey)) {
					var adrs = gtapp.BytesToString(datas);
					success(adrs);
				} else {
					alert("交易打包无效");
				}
			}
		});
	},
	RequestSwapAccount: function(success) {
		var publicKey = GT.Global.Wallet.getAccounts()[0].publicKey.encodePoint(true).toHexString();
		// alert(publicKey);
		gtapp.WalletExist().then(function(result) {
			if (result) {
				var urlroot = gtapp.GetApiUrl();
				var url = urlroot + "/api/GetSwapEth" + "?publicKey=" + publicKey + "&r=" + Math.random();
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
	PostEthTxId: function(ethtxid, success) {
		gtapp.DoPostEthTxId(ethtxid, function(resp) {
			// alert(resp.result);
			if (resp.result) {
				success(resp);
			} else {
				alert(resp.error);
			}
		});
	},
	DoPostEthTxId: function(ethtxid, success) {
		var publicKey = GT.Global.Wallet.getAccounts()[0].publicKey.encodePoint(true).toHexString();
		gtapp.WalletExist().then(function(result) {
			if (result) {
				var urlroot = gtapp.GetApiUrl();
				var url = urlroot + "/api/PostEthTxId" + "?publicKey=" + publicKey + "&ethtxid=" + ethtxid;
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
					if (spvlidators.indexOf(resp.pubkey) >= 0 && gtapp.verifyByPublicKey(strTx.hexToBytes(), resp.signature.hexToBytes(),
							resp.pubkey)) {
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
					} else {
						alert("交易打包无效");
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
	BytesToString: function(arr) {
		if (typeof arr === 'string') {
			return arr;
		}
		var str = '',
			_arr = arr;
		for (var i = 0; i < _arr.length; i++) {
			var one = _arr[i].toString(2),
				v = one.match(/^1+?(?=0)/);
			if (v && one.length == 8) {
				var bytesLength = v[0].length;
				var store = _arr[i].toString(2).slice(7 - bytesLength);
				for (var st = 1; st < bytesLength; st++) {
					store += _arr[st + i].toString(2).slice(2);
				}
				str += String.fromCharCode(parseInt(store, 2));
				i += bytesLength - 1;
			} else {
				str += String.fromCharCode(_arr[i]);
			}
		}
		return str;
	}
};
