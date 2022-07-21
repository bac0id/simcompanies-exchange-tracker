using SimcompaniesHelper.Winform.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimcompaniesHelper.Winform {
	public partial class FormConfig : Form {

		public FormConfig() {
			InitializeComponent();
			this.LoadConfigView();
		}

		private void LoadConfigView() {
			this.ckbTopMost.Checked = Settings.Default.TopMost;
			this.ckbAtutoRefresh.Checked = Settings.Default.AutoRefresh;
			this.tbAutuRefreshInterval.Text = Settings.Default.AutoRefreshInterval.ToString();
			this.tbFollowIds.Text = this.LoadFollowIdFile();
		}

		private void SaveConfig() {
			Settings.Default.TopMost = this.ckbTopMost.Checked;
			Settings.Default.AutoRefresh = this.ckbAtutoRefresh.Checked;
			if (int.TryParse(this.tbAutuRefreshInterval.Text, out int refreshInterval)) {
				Settings.Default.AutoRefreshInterval = refreshInterval;
			}

			FileStream fs = new FileStream(Resources.FollowIdsFilename, FileMode.Create);
			StreamWriter sw = new StreamWriter(fs);
			foreach (var line in this.tbFollowIds.Text.Split('\n')) {
				string s = line.Trim();
				if (int.TryParse(s, out int id)) {
					sw.WriteLine(id);
				} else {
					
				}
			}
			sw.Close();

			Settings.Default.Save();
		}

		private string LoadFollowIdFile() {
			FileStream fs = new FileStream(Resources.FollowIdsFilename, FileMode.OpenOrCreate);
			StreamReader sr = new StreamReader(fs);
			string content = sr.ReadToEnd();
			sr.Close();
			return content;
		}

		private void btnOK_Click(object sender, EventArgs e) {
			this.SaveConfig();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
