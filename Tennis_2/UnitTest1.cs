using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Love_all()
        {
            TennisGame tennisGame = new TennisGame();
            string score = tennisGame.GetScore();
            Assert.AreEqual("Love All", score);
        }
    }
}
