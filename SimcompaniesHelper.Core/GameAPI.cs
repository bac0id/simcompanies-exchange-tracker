using SimcompaniesHelper.Core.Util;
using System.Text.Json;

namespace SimcompaniesHelper.Core {
	public static class GameAPI {

		private const string BaseUrl = "https://www.simcompanies.com/";

		private static Exchange exchange = Exchange.Singleton;

		public static void RefreshExchangePrice() {
			// This API is weird. If you pass current UTC time as the parameter,
			// it will return only ~40 of ~145 items's info of game, other items are missing.
			// So I write "AddYears(-1)"
			DateTime dt = DateTime.Now.ToUniversalTime().AddYears(-1);
			// API URL Example: https://www.simcompanies.com/api/v2/market-ticker/0/2022-07-11T06:33:32.450Z/
			string url = $"{BaseUrl}api/v2/market-ticker/0/{dt.ToString("yyyy-MM-ddTHH:mm:ss.000Z")}/";

			// Deserialize the json manually. LOL!
			string json;
			try {
				json = HttpHelper.HttpGet(url);
				exchange.LastRefreshTime = DateTime.Now;
			}
			catch (Exception) {
				return;
			}
			var exchangeItems = json.Split('}');
			foreach (var exchangeItem in exchangeItems) {
				// 最后可能有一个"]"字符串，跳过
				if (exchangeItem.Length < 2) continue;
				// 一个商品数据，用,分隔，表示一对属性和值
				var properties = exchangeItem.Split(',');
				int id = 0;
				string name = "";
				double price = 0;
				foreach (var property in properties) {
					if (string.IsNullOrEmpty(property)) continue;
					var kv = property.Split(':');
					string k = kv[0], v = kv[1];
					if (k.Contains("image")) {
						// v类似这样"：images/resources/golden-bars.png"
						// 处理后得到"golden-bars"
						name = v.Split('/')[2].Split('.')[0];
					} else if (k.Contains("price")) {
						price = double.Parse(v);
					} else if (k.Contains("kind")) {
						id = int.Parse(v);
					}
				}
				if (exchange.Products.ContainsKey(id) == false) {
					exchange.Products.Add(id, new Product(id, name, price));
				} else {
					exchange.Products[id].Price = price;
				}
			}
		}

		public static Encyclopedia GetEncyclopedia(int id) {
			string url = $"{BaseUrl}api/v4/zh/0/encyclopedia/resources/1/{id}";
			string json = HttpHelper.HttpGet(url);
			JsonSerializerOptions options = new JsonSerializerOptions();
			// Ignore null values
			options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
			options.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.WriteAsString;
			Encyclopedia item = JsonSerializer.Deserialize<Encyclopedia>(json, options);
			return item;
		}
	}
}
