namespace SimcompaniesHelper.Core.Util {
	public class NumberStatistics {

		private int maxRrecentStatCount;
		private double recentSum;
		private LinkedList<double> recentVals = new LinkedList<double>();
		private IDictionary<double, int> recentValsCount = new Dictionary<double, int>();

		public double HistoricalMin { get; private set; } = double.MaxValue;
		public double HistoricalMax { get; private set; } = double.MinValue;
		public double RecentMin {
			get {
				if (this.recentVals.Count == 0) {
					return double.NaN;
				}
				return this.recentValsCount.Keys.Min();
			}
		}
		public double RecentMax {
			get {
				if (this.recentVals.Count == 0) {
					return double.NaN;
				}
				return this.recentValsCount.Keys.Max();
			}
		}
		public double RecentAverage => this.recentSum / this.recentVals.Count;

		public IEnumerable<double> RecentVals => this.recentVals;

		public int MaxRecentStatCount {
			get => this.maxRrecentStatCount;
			set {
				this.maxRrecentStatCount = value;
				this.EnsuredRecentStatCount();
			}
		}

		public int RecentStatCount => this.recentVals.Count;

		public NumberStatistics(int maxRrecentStatCount) {
			if (maxRrecentStatCount < 1) {
				throw new ArgumentException();
			}
			this.maxRrecentStatCount = maxRrecentStatCount;
		}

		public void Add(double val) {
			if (val < this.HistoricalMin) this.HistoricalMin = val;
			if (val > this.HistoricalMax) this.HistoricalMax = val;
			this.AddLatestVal(val);
			this.EnsuredRecentStatCount();
		}

		private void EnsuredRecentStatCount() {
			while (this.recentVals.Count > this.maxRrecentStatCount) {
				this.RemoveEarlistVal();
			}
		}

		private void AddLatestVal(double val) {
			this.recentSum += val;
			this.recentVals.AddLast(val);
			if (this.recentValsCount.ContainsKey(val)) {
				this.recentValsCount[val]++;
			} else {
				this.recentValsCount.Add(val, 1);
			}
		}

		private void RemoveEarlistVal() {
			double earlistVal = this.recentVals.First.Value;
			this.recentSum -= earlistVal;
			this.recentVals.RemoveFirst();
			if (this.recentValsCount.ContainsKey(earlistVal)) {
				this.recentValsCount[earlistVal]--;
				if (this.recentValsCount[earlistVal] == 0) {
					this.recentValsCount.Remove(earlistVal);
				}
			}
		}
	}
}