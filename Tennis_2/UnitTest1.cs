using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_2
{
    [TestClass]
    public class UnitTest1
    {
        private TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void Love_all()
        {
            ScoreShouldBe("Love All");
        }

        private void ScoreShouldBe(string expected)
        {
            string score = tennisGame.GetScore();
            Assert.AreEqual(expected, score);
        }
    }
}