using SimcompaniesHelper.Core.Util;

namespace SimcompaniesHelper.Test {
	public class NumberStatisticsTest {

		[SetUp]
		public void Setup() {

		}

		[Test]
		public void TestSlidingWindow() {
			NumberStatistics stat = new NumberStatistics(3);
			stat.Add(1);
			stat.Add(2);
			stat.Add(3);
			Assert.That(stat.RecentAverage, Is.EqualTo(2));
			stat.Add(4);
			stat.Add(5);
			// Now recent prices = [3,4,5]
			Assert.That(stat.RecentAverage, Is.EqualTo(4));
			Assert.That(stat.RecentMin, Is.EqualTo(3));
			Assert.That(stat.RecentMax, Is.EqualTo(5));
			Assert.That(stat.HistoricalMin, Is.EqualTo(1));
			Assert.That(stat.HistoricalMax, Is.EqualTo(5));
			stat.Add(6);
			// Now recent prices = [4,5,6]
			Assert.That(stat.RecentAverage, Is.EqualTo(5));
			Assert.That(stat.RecentMin, Is.EqualTo(4));
			Assert.That(stat.RecentMax, Is.EqualTo(6));
			Assert.That(stat.HistoricalMin, Is.EqualTo(1));
			Assert.That(stat.HistoricalMax, Is.EqualTo(6));
		}

		[Test]
		public void TestRecentCountZero() {
			NumberStatistics stat = new NumberStatistics(1);
			stat.Add(1);
			Assert.That(stat.RecentAverage, Is.EqualTo(1));
			Assert.That(stat.RecentMin, Is.EqualTo(1));
			Assert.That(stat.RecentMax, Is.EqualTo(1));
			Assert.That(stat.HistoricalMin, Is.EqualTo(1));
			Assert.That(stat.HistoricalMax, Is.EqualTo(1));
			stat.Add(2);
			Assert.That(stat.RecentAverage, Is.EqualTo(2));
			Assert.That(stat.RecentMin, Is.EqualTo(2));
			Assert.That(stat.RecentMax, Is.EqualTo(2));
			Assert.That(stat.HistoricalMin, Is.EqualTo(1));
			Assert.That(stat.HistoricalMax, Is.EqualTo(2));
		}

		[Test]
		public void TestAdjustRecentStatSize() {
			NumberStatistics stat = new NumberStatistics(2);
			stat.Add(1);
			stat.Add(2);
			Assert.That(stat.RecentAverage, Is.EqualTo(1.5));
			stat.MaxRecentStatCount = 5;
			stat.Add(3);
			stat.Add(4);
			stat.Add(5);
			Assert.That(stat.RecentAverage, Is.EqualTo(3));
			stat.MaxRecentStatCount = 2;
			Assert.That(stat.RecentAverage, Is.EqualTo(4.5));
		}
	}
}
