using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

using LocalData;

namespace LocalDataTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LocalData.LocalData localData = new LocalData.LocalData();
        }
    }
}
