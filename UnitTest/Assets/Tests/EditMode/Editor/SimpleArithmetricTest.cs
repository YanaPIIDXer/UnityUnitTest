using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SimpleArithmetricTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void AddTest()
        {
            SimpleArithmetric TestTarget = new SimpleArithmetric(1, 2);
            Assert.AreEqual(TestTarget.Add(), 3);
        }

        [Test]
        public void SubTest()
        {
            SimpleArithmetric TestTarget = new SimpleArithmetric(5, 3);
            Assert.AreEqual(TestTarget.Sub(), 2);
        }
    }
}
