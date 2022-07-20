namespace SimcompaniesHelper.Core.Util {
	public static class HttpHelper {
		private static readonly HttpClient client = new HttpClient();
		public static string HttpGet(string url) {
			HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();
			response.EnsureSuccessStatusCode();
			string responseBody = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
			// Above three lines can be replaced with new helper method below
			// string responseBody = await client.GetStringAsync(uri);
			return responseBody;
		}
	}
}
