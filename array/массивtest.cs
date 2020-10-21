using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Series.Tests
{
    [TestClass]
    public class SeriesTest
    {
        [TestMethod]
        public void Test1Series16_3andArray123450_5Expected()
        {
          
            int k = 3;
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 0 };
            int expected = 5;

            MyTasks t = new MyTasks();
            int actual = t.Series16(k, arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2Series16_7andArray123450_0Expected()
        {
            int k = 7;
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 0 };
            int expected = 0;

            Tasks t = new Tasks();
            int actual = t.Series16(k, arr);


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1Series22_5andArray54321_0Expected()
        {

            int n = 5;
            double[] arr = new double[5] { 5, 4, 3, 2, 1 };
            int expected = 0;


            Tasks t = new Tasks();
            int actual = t.Series22(n, arr);


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2Series22_5andArray56321_2Expected()
        {
            int n = 5;
            double[] arr = new double[5] { 5, 6, 3, 2, 1 };
            int expected = 2;

            Tasks t = new Tasks();
            int actual = t.Series22(n, arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1Series24_5andArray00050_5Expected()
        {
            int n = 5;
            int[] arr = new int[5] { 0, 0, 0, 5, 0 };
            int expected = 5;


            Tasks t = new Tasks();
            int actual = t.Series24(n, arr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2Series24_5andArray05000_0Expected()
        {
            int n = 5;
            int[] arr = new int[5] { 0, 5, 0, 0, 0 };
            int expected = 0;

            Tasks t = new Tasks();
            int actual = t.Series24(n, arr);

            Assert.AreEqual(expected, actual);
        }
    }
}