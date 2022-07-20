using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimcompaniesHelper.Core {
	public class Exchange {

		private static Exchange singleton;

		public static Exchange Singleton {
			get {
				if (singleton == null) {
					singleton = new Exchange();
				}
				return singleton;
			}
		}

		public IDictionary<int, Product> Products { get; } = new Dictionary<int, Product>();
		public DateTime LastRefreshTime { get; set; }

		private Exchange() {

		}
	}
}
