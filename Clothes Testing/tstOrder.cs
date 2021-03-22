using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothes_Testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
    }
}
