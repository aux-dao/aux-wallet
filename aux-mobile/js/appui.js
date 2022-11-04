var appui = {
	setSettings: function(settings) {
		settings = settings || {};
		localStorage.setItem('$settings', JSON.stringify(settings));
	},

	/**
	 * 设置spv服务节点
	 **/
	getSettings: function() {
		var settingsText = localStorage.getItem('$settings') || "{}";
		return JSON.parse(settingsText);
	},
	setNodes: function(settings) {
		settings = settings || {};
		localStorage.setItem('$nodes', JSON.stringify(settings));
	},
	setSpvs: function(settings) {
		settings = settings || {};
		localStorage.setItem('$spvs', JSON.stringify(settings));
	},
	setCurrentSpv: function(settings) {		 
		localStorage.setItem('$currentspv',settings);
	},
	/**
	 * 设置应用本地配置
	 **/
	 getCurrentSpv: function() {
	 	return localStorage.getItem('$currentspv') || "";
	 },
	 getSpvs: function() {
	 	var settingsText = localStorage.getItem('$spvs') || "[]";
	 	return JSON.parse(settingsText);
	 },
	getNodes: function() {
		var settingsText = localStorage.getItem('$nodes') || "{}";
		return JSON.parse(settingsText);
	},

	setRoomPwds: function(settings) {
		settings = settings || {};
		localStorage.setItem('$roompwds', JSON.stringify(settings));
	},

	/**
	 * 设置应用本地配置
	 **/
	getRoomPwds: function() {
		var settingsText = localStorage.getItem('$roompwds') || "{}";
		return JSON.parse(settingsText);
	},

	setDealers: function(settings) {
		settings = settings || {};
		localStorage.setItem('$dealers', JSON.stringify(settings));
	},

	/**
	 * 设置应用本地配置
	 **/
	getDealers: function() {
		var settingsText = localStorage.getItem('$dealers') || "{}";
		return JSON.parse(settingsText);
	},
	setTrustAddress: function(settings) {
		localStorage.setItem('$trustaddress', settings);
	},

	/**
	 * 设置应用本地配置
	 **/
	getTrustAddress: function() {
		return localStorage.getItem('$trustaddress');
	},
	setLockPwd: function(settings) {
		localStorage.setItem('$lockpwd', settings);
	},

	/**
	 * 设置应用本地配置
	 **/
	getLockPwd: function() {
		return localStorage.getItem('$lockpwd');
	}
};
