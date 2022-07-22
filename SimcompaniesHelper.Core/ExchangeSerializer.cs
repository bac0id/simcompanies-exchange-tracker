namespace SimcompaniesHelper.Core {
	/// <summary>
	/// Exchange Serializer
	/// <para>
	/// Format:
	///  1st line: Last Refresh Time
	///  2nd line: Product Count(n)
	///  3rd to 3+n th lines: Product id, name, price, its recentPriceVals from earlist to latest
	/// </para>
	/// </summary>
	public static class ExchangeSerializer {
		public static void Serialize(string filename, Exchange exchange) {
			if (string.IsNullOrWhiteSpace(filename) || exchange == null) {
				throw new ArgumentNullException();
			}

			FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
			StreamWriter sw = new StreamWriter(fs);

			sw.WriteLine(exchange.LastRefreshTime.Ticks);
			sw.WriteLine(exchange.Products.Values.Count);
			foreach (var product in exchange.Products.Values) {
				sw.Write($"{product.Id} {product.Name} {product.Price} {product.Statistics.HistoricalMin} {product.Statistics.HistoricalMax}");
				foreach (var val in product.Statistics.RecentVals) {
					sw.Write($" {val}");
				}
				sw.WriteLine();
			}
			sw.Close();
		}

		public static void Deserialize(string filename, Exchange exchange) {
			if (string.IsNullOrWhiteSpace(filename) || exchange == null) {
				throw new ArgumentNullException();
			}

			FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
			StreamReader sr = new StreamReader(fs);

			exchange.LastRefreshTime = new DateTime(long.Parse(sr.ReadLine()));
			int productCount = int.Parse(sr.ReadLine());
			for (int i = 0; i < productCount; ++i) {
				string line = sr.ReadLine();
				string[] fields = line.Split(' ');

				int id = int.Parse(fields[0]);
				string name = fields[1];
				double price = double.Parse(fields[2]);
				double min = double.Parse(fields[3]);
				double max = double.Parse(fields[4]);

				Product p = new Product(id, name, price);
				// Bug: may cause inaccurate statistics
				p.Price = min;
				p.Price = max;

				// Insert all recent prices
				for (int j = 5; j < fields.Length; ++j) {
					p.Price = double.Parse(fields[j]);
				}

				if (exchange.Products.ContainsKey(id)) {
					exchange.Products[id] = p;
				} else {
					exchange.Products.Add(id, p);
				}
			}
			sr.Close();
		}
	}
}
