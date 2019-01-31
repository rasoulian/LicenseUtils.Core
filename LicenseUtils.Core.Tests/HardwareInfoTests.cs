using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LicenseUtils.Core.Tests
{
    [TestClass]
    public class HardwareInfoTests
    {
        [TestMethod]
        public void CurrentSystem_UID_NotBeNull()
        {
            var info = HardwareInfo.GenerateUID("app1");
            Assert.IsNotNull(info);
        }
    }
}
