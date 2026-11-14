using Tyuiu.AksenovFM.Sprint3.Task0.V7.Lib;

namespace Tyuiu.AksenovFM.Sprint3.Task0.V7.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 0.469;
            Assert.AreEqual(wait, res);
        }
    }
}