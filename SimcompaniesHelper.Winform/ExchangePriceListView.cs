using SimcompaniesHelper.Core;

namespace SimcompaniesHelper.Winform {
	public class ExchangePriceListView {

		public ICollection<int> Ids { get; set; }

		private ListView lv;
		private Exchange exchange;
		private IDictionary<int, ListViewItem> idToLvItem = new Dictionary<int, ListViewItem>();

		public ExchangePriceListView(ListView lv, Exchange exchange) : this(lv, exchange, exchange.Products.Keys) {

		}

		public ExchangePriceListView(ListView lv, Exchange exchange, ICollection<int> ids) {
			this.lv = lv ?? throw new ArgumentNullException(nameof(lv));
			this.exchange = exchange ?? throw new ArgumentNullException(nameof(exchange));
			this.Ids = ids;
			this.lv.Items.Clear();
		}

		public void Update() {
			foreach (var id in Ids) {
				var product = exchange.Products[id];
				if (idToLvItem.ContainsKey(id) == false) {
					var newItem = new ListViewItem(id.ToString());
					newItem.UseItemStyleForSubItems = false;
					newItem.SubItems.Add(product.Name);
					newItem.SubItems.Add(product.Price.ToString());
					newItem.SubItems.Add(product.Statistics.RecentAverage.ToString());
					newItem.SubItems.Add(product.Statistics.RecentMin.ToString());
					newItem.SubItems.Add(product.Statistics.RecentMax.ToString());
					newItem.SubItems.Add(product.Statistics.HistoricalMin.ToString());
					newItem.SubItems.Add(product.Statistics.HistoricalMax.ToString());
					idToLvItem.Add(id, newItem);
					lv.Items.Add(newItem);
				}

				var item = idToLvItem[id];

				// Decide the display style depends on product's price
				if (product.IsMin()) {
					item.SubItems[2].ForeColor = Color.White;
					item.SubItems[2].BackColor = Color.DarkGreen;
				} else if (product.IsRecentMin()) {
					item.SubItems[2].ForeColor = Color.White;
					item.SubItems[2].BackColor = Color.Green;
				} else if (product.IsLowerThanRecentAverage()) {
					item.SubItems[2].ForeColor = Color.White;
					item.SubItems[2].BackColor = Color.DarkSeaGreen;
				} else {
					item.SubItems[2].ForeColor = item.SubItems[0].ForeColor;
					item.SubItems[2].BackColor = item.SubItems[0].BackColor;
				}

				// Update displaed texts
				item.SubItems[2].Text = product.Price.ToString();
				item.SubItems[3].Text = product.Statistics.RecentAverage.ToString();
				item.SubItems[4].Text = product.Statistics.RecentMin.ToString();
				item.SubItems[5].Text = product.Statistics.RecentMax.ToString();
				item.SubItems[6].Text = product.Statistics.HistoricalMin.ToString();
				item.SubItems[7].Text = product.Statistics.HistoricalMax.ToString();
			}
		}
	}
}
