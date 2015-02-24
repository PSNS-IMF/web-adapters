using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Psns.Common.Web.Adapters;

namespace Adapters.UnitTests
{
    [TestClass]
    public class WhenWorkingWithTheAntiForgeryHelperAdapter
    {
        bool _called;

        [TestMethod]
        public void TheSuppliedFunctionShouldBeInvoked()
        {
            AntiForgeryHelperAdapter.ValidationFunction = () => _called = true;
            AntiForgeryHelperAdapter.Validate();

            Assert.IsTrue(_called);
        }
    }
}
