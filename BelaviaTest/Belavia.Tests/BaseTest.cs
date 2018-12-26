using Microsoft.VisualStudio.TestTools.UnitTesting;
using BelaviaFrameworkTest;

namespace Belavia.Tests
{
    [TestClass]
    public class BaseTest
    {
        [TestCleanup]
        public void CleanupTest()
        {
            Driver.QuitDriver();
        }
    }
}
