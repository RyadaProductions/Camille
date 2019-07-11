using Microsoft.VisualStudio.TestTools.UnitTesting;
using MingweiSamuel.Camille.Entity;

namespace Camille.Entity.Test
{
    [TestClass]
    public class SummonerMatchlistQueryTest
    {
        [TestMethod]
        public void TestEquality()
        {
            var q1 = new SummonerMatchlistQuery();
            var q2 = new SummonerMatchlistQuery();
            Assert.AreEqual(q1, q2);

            var q3 = new SummonerMatchlistQuery(queue: new [] { 420 });
            var q4 = new SummonerMatchlistQuery(queue: new [] { 420 });
            Assert.AreEqual(q3, q4);
            Assert.AreNotEqual(q1, q3);

            var q5 = new SummonerMatchlistQuery(beginTime: 1234, endTime: 1234);
            var q6 = new SummonerMatchlistQuery(beginTime: 1234, endTime: 1234);
            Assert.AreEqual(q5, q6);
            Assert.AreNotEqual(q1, q5);
            Assert.AreNotEqual(q3, q5);

            var q7 = new SummonerMatchlistQuery(queue: new int[] {});
            Assert.AreNotEqual(q3, q7);
            Assert.AreNotEqual(q3.GetHashCode(), q7.GetHashCode());
            // Empty is equivalent to null.
            Assert.AreEqual(q1, q7);
            Assert.AreEqual(q1.GetHashCode(), q7.GetHashCode());
        }
    }
}
