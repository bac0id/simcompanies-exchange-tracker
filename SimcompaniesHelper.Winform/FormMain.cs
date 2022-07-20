using SimcompaniesHelper.Core;
using System.ComponentModel;
using ScottPlot;

namespace SimcompaniesHelper.Winform {
	public partial class FormMain : Form {

		private const string FollowIdsFilename = "follow_list.txt";
		private const string ExchangeDataFilename = "exchange_data";

		private ICollection<int> followIds = new List<int>();
		private Exchange exchange = Exchange.Singleton;
		private ExchangePriceListView priceListVIew;

		public FormMain() {
			InitializeComponent();
			LoadConfig();
			timerRefreshExchange.Interval = 1000;
			this.timerRefreshExchange.Enabled = this.toolStripMenuItemAutoRefresh.Checked;
			this.priceListVIew = new ExchangePriceListView(lvPriceListView, exchange, followIds);
		}
		private void LoadConfig() {
			LoadFollowIds();
		}

		private void timerRefreshExchange_Tick(object sender, EventArgs e) {
			TryRefreshMarket();
		}

		private void LoadFollowIds() {
			this.followIds.Clear();
			FileStream fs = new FileStream(FollowIdsFilename, FileMode.OpenOrCreate);
			StreamReader sr = new StreamReader(fs);
			string[] lines = sr.ReadToEnd().Split('\n');
			foreach (var line in lines) {
				string idStr = line.Trim();
				int id = int.Parse(idStr);
				this.followIds.Add(id);
			}
			sr.Close();
		}

		private void SaveFollowId(ICollection<int> followIds) {
			FileStream fs = new FileStream(FollowIdsFilename, FileMode.OpenOrCreate);
			StreamWriter sw = new StreamWriter(fs);
			foreach (var id in followIds) {
				sw.WriteLine(id);
			}
			sw.Close();
		}

		private void UpdateExchangePriceListView() {
			this.priceListVIew.Update();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
			GameAPI.RefreshExchangePrice();
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			this.UpdateExchangePriceListView();
			this.toolStripStatusLabelRefreshTime.Text = exchange.LastRefreshTime.ToString();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e) {
			TryRefreshMarket();
		}

		private void TryRefreshMarket() {
			if (backgroundWorker1.IsBusy) return;
			backgroundWorker1.RunWorkerAsync();
		}

		private void toolStripMenuItemAutoRefresh_CheckedChanged(object sender, EventArgs e) {
			this.timerRefreshExchange.Enabled = this.toolStripMenuItemAutoRefresh.Checked;
		}

		private void toolStripMenuItemTopMost_CheckedChanged(object sender, EventArgs e) {
			this.TopMost = this.toolStripMenuItemTopMost.Checked;
		}

		private void editListToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show($"Not implemented yet.\nPlease modify \"{FollowIdsFilename}\" directly then restart this app!");
		}

		private void inportToolStripMenuItem_Click(object sender, EventArgs e) {
			ExchangeSerializer.Deserialize(ExchangeDataFilename,exchange);
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
			ExchangeSerializer.Serialize(ExchangeDataFilename, exchange);
		}


		private void lvPriceListView_SelectedIndexChanged(object sender, EventArgs e) {
			if (this.lvPriceListView.SelectedItems.Count == 0) {

			} else {
				var item = this.lvPriceListView.SelectedItems[0];
				int id = int.Parse(item.Text);
				ProductPricePlotter.Plot(this.formsPlot1, this.exchange.Products[id]);
			}
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e) {
			// Save TopMost field
			bool topMost = this.TopMost;
			this.TopMost = false;

			Form fmAbout = new FormAbout();
			fmAbout.ShowDialog();

			// Retrieve TopMost field
			this.TopMost = topMost;
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e) {
			string msg = $"Id: id of product. \n" +
				$"Name: name of product in English. \n" +
				$"Now: current price. \n" +
				$"Ravg: Recent average price. \n" +
				$"Rmin: Recent lowest price. \n" +
				$"Rmax: Recent highest price. \n" +
				$"Hmin: Lowest price recorded so far. \n" +
				$"Hmax: Highest price recorded so far. \n";
			MessageBox.Show(msg);
		}
	}
}
