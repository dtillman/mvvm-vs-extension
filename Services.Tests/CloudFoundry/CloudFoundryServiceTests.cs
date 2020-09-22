using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tanzu.Tools.Services.CloudFoundry
{
    [TestClass()]
    public class CloudFoundryServiceTests
    {

        [TestInitialize]
        public void TestInit()
        {
        }
        
        public void ConnectToCFAsync_ValidatesParameters()
        {
            var cfService = new CloudFoundryService();
            Assert.ThrowsException<ArgumentException>(() => cfService.ConnectToCFAsync(null, null, null, null, false));
            Assert.ThrowsException<ArgumentException>(() => cfService.ConnectToCFAsync(string.Empty, null, null, null, false));
            Assert.ThrowsException<ArgumentException>(() => cfService.ConnectToCFAsync("Junk", null, null, null, false));
            Assert.ThrowsException<ArgumentException>(() => cfService.ConnectToCFAsync("Junk", string.Empty, null, null, false));
            Assert.ThrowsException<ArgumentException>(() => cfService.ConnectToCFAsync("Junk", "Junk", null, null, false));
        }
    }
}
