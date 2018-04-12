using Microsoft.VisualStudio.TestTools.UnitTesting;
using NTL___Never_too_late;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTL___Never_too_late.Tests
{
    [TestClass()]
    public class VocabularyTests
    {
        [TestMethod()]
        public void swapTest()
        {
            int a = 5;
            int b = 6;
            int expected = 6;
            Vocabulary voc = new Vocabulary();
            voc.swap<int>(ref a, ref b);
            int result = a;
            Assert.AreEqual(expected, result);
            Assert.Inconclusive("wszystko okej");
        }
    }
}