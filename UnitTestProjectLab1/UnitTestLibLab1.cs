using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProjectLab1
{
    [TestClass]
    public class UnitTestLibLab1
    {
        [TestMethod]
        public void TestExpression()
        {
            double a = 1;
            double x = 1;
            double y = 1;
            ClassLab1 expr = new ClassLab1();

            double res = expr.Expression(a, x, y);
            double wait = 5.5;

            Assert.AreEqual(Math.Round(wait, 1), Math.Round(res, 1));

            double res1 = expr.Expression1(a, x, y);

            wait = 3.5;

            Assert.AreEqual(Math.Round(wait, 1), Math.Round(res1, 1));
        }
    }
}
