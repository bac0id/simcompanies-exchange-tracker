namespace SimcompaniesHelper.Core {
	public class Encyclopedia {
		public string name { get; set; }
		public string image { get; set; }
		public int db_letter { get; set; }
		public float transportation { get; set; }
		public Nullable<bool> retailable { get; set; }
		public bool research { get; set; }
		public bool realmAvailable { get; set; }
		public Producedfrom[] producedFrom { get; set; }
		public Soldat soldAt { get; set; }
		public object soldAtRestaurant { get; set; }
		public Producedat producedAt { get; set; }
		public object[] neededFor { get; set; }
		public float transportNeeded { get; set; }
		public float producedAnHour { get; set; }
		/// <summary>
		/// Salary of product building
		/// </summary>
		public float baseSalary { get; set; }
		public Nullable<float> averageRetailPrice { get; set; }
		public Nullable<float> marketSaturation { get; set; }
		public string marketSaturationLabel { get; set; }
		public string retailModeling { get; set; }
		/// <summary>
		/// Salary of retail building
		/// </summary>
		public Nullable<float> storeBaseSalary { get; set; }
		public Retaildata[] retailData { get; set; }
		public object[] improvesQualityOf { get; set; }
	}

}