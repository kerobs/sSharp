using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KerobsLibrary;

namespace web.Tests
{
    [TestClass]
    public class MyTestCase
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        // unit test code
        [TestMethod]
        public void GetPalindromeWordsFromSentence()
        {
            string inputstr = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            string expected = "hijkllkjih";
            IUtility _service = (IUtility)new Utility();

            List<sText> actual = _service.GetPalindromeWords(inputstr);
            Assert.AreEqual(expected, actual[0]._word, "", "Not working properly");
        }
    }
}