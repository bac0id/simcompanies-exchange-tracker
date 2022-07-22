using SimcompaniesHelper.Core;
using System.ComponentModel;
using SimcompaniesHelper.Winform.Properties;

namespace SimcompaniesHelper.Winform {
	public partial class FormMain : Form {

		private const string ExchangeDataFilename = "exchange_data";

		private ICollection<int> followIds = new HashSet<int>();
		private Exchange exchange = Exchange.Singleton;
		private ExchangePriceListView priceListVIew;

		private const bool DebugFlag = false;

		public FormMain() {
			InitializeComponent();
			this.priceListVIew = new ExchangePriceListView(lvPriceListView, exchange, followIds);
			LoadConfig();
		}
		private void LoadConfig() {
			LoadFollowIds();
			this.priceListVIew.Ids = followIds;
			LoadTimer();
			LoadMainFormConfig();
		}

		private void timerRefreshExchange_Tick(object sender, EventArgs e) {
			TryRefreshExchangePrice();
		}

		private void LoadFollowIds() {
			this.followIds = new HashSet<int>();
			FileStream fs = new FileStream(Resources.FollowIdsFilename, FileMode.OpenOrCreate);
			StreamReader sr = new StreamReader(fs);
			string[] lines = sr.ReadToEnd().Split('\n');
			foreach (var line in lines) {
				string idStr = line.Trim();
				if (int.TryParse(idStr, out int id)) {
					this.followIds.Add(id);
				}
			}
			sr.Close();
		}

		private void LoadTimer() {
			this.timerRefreshExchange.Interval = Settings.Default.AutoRefreshInterval;
			this.timerRefreshExchange.Enabled = Settings.Default.AutoRefresh;
		}

		private void LoadMainFormConfig() {
			this.TopMost = Settings.Default.TopMost;
			this.Width = Settings.Default.MainFormWidth;
			this.Height = Settings.Default.MainFormHeight;
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
			this.UpdateFormPlotToSelectedItem();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e) {
			TryRefreshExchangePrice();
		}

		private void TryRefreshExchangePrice() {
			if (backgroundWorker1.IsBusy) return;
			backgroundWorker1.RunWorkerAsync();
		}

		private void inportToolStripMenuItem_Click(object sender, EventArgs e) {
			ExchangeSerializer.Deserialize(ExchangeDataFilename, exchange);
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e) {
			ExchangeSerializer.Serialize(ExchangeDataFilename, exchange);
		}

		private void lvPriceListView_SelectedIndexChanged(object sender, EventArgs e) {
			this.UpdateFormPlotToSelectedItem();
		}

		private void UpdateFormPlotToSelectedItem() {
			if (this.lvPriceListView.SelectedItems.Count > 0) {
				var item = this.lvPriceListView.SelectedItems[0];
				int id = int.Parse(item.Text);
				ProductPricePlotter.Plot(this.formsPlot1, this.exchange.Products[id]);
			}
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e) {
			this.ShowDialogForm(new FormAbout());
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

		private void toolStripMenuItem3_Click(object sender, EventArgs e) {
			var result = ShowDialogForm(new FormConfig());
			if (result == DialogResult.OK) {
				this.LoadConfig();
			}
		}

		private DialogResult ShowDialogForm(Form form) {
			// Save TopMost field
			bool topMost = this.TopMost;
			this.TopMost = false;

			var result = form.ShowDialog(this);

			// Retrieve TopMost field
			this.TopMost = topMost;

			return result;
		}

		private void FormMain_ResizeEnd(object sender, EventArgs e) {
			Settings.Default.MainFormWidth = this.Width;
			Settings.Default.MainFormHeight = this.Height;
			Settings.Default.Save();
		}
	}
}
