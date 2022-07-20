using SimcompaniesHelper.Core.Util;

namespace SimcompaniesHelper.Core {
	public class Product {

		private const int DefaultRecentStatCount = 300;

		private double price;

		public int Id { get; private set; }
		public string Name { get; private set; }
		public NumberStatistics Statistics { get; private set; }
		public double Price {
			get => this.price;
			set {
				this.price = value;
				this.Statistics.Add(value);
			}
		}

		public Product(int id, string name, double price) {
			this.Statistics = new NumberStatistics(DefaultRecentStatCount);
			this.Id = id;
			this.Name = name;
			this.Price = price;
		}

		public bool IsMin() {
			return this.price <= this.Statistics.HistoricalMin;
		}

		public bool IsRecentMin() {
			return this.price <= this.Statistics.RecentMin;
		}

		public bool IsLowerThanRecentAverage() {
			return this.price < this.Statistics.RecentAverage;
		}
	}
}
