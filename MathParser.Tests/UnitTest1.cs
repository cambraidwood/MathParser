using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathParser.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Acceptance_Criteria_1()
        {

            Assert.AreEqual(MathParser.Program.parse("3a2c4"), 20);

        }

        [TestMethod]
        public void Test_Acceptance_Criteria_2()
        {

            Assert.AreEqual(MathParser.Program.parse("32a2d2"), 17);

        }

        [TestMethod]
        public void Test_Acceptance_Criteria_3()
        {

            Assert.AreEqual(MathParser.Program.parse("500a10b66c32"), 14208);

        }

        [TestMethod]
        public void Test_Acceptance_Criteria_4()
        {

            Assert.AreEqual(MathParser.Program.parse("3ae4c66fb32"), 235);

        }

        [TestMethod]
        public void Test_Acceptance_Criteria_5()
        {

            Assert.AreEqual(MathParser.Program.parse("3c4d2aee2a4c41fc4f"), 990);

        }
    }
}
