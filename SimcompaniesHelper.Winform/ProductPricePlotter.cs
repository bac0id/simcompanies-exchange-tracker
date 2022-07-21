using ScottPlot;
using SimcompaniesHelper.Core;

namespace SimcompaniesHelper.Winform {
	public static class ProductPricePlotter {
		public static void Plot(FormsPlot formsPlot, Product product) {
			int i;
			int dataCnt = product.Statistics.RecentStatCount;
			/*
			// dataX = [0,1,2,...]
			double[] dataX = new double[dataCnt];
			for (i = 0; i < dataCnt; ++i) {
				dataX[i] = i;
			}
			*/
			// dataY are recorded recent prices
			double[] dataY = new double[dataCnt];
			i = 0;
			foreach (var val in product.Statistics.RecentVals) {
				dataY[i++] = val;
			}
			formsPlot.Plot.Clear();
			// if you use Plot.AddScatter you need create the dataX
			//formsPlot.Plot.AddScatter(dataX, dataY);
			formsPlot.Plot.AddSignal(dataY);
			formsPlot.Plot.AxisAutoX();
			formsPlot.Plot.AxisAutoY();
			formsPlot.Refresh();
		}
	}
}
