using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_2
{
    [TestClass]
    public class UnitTest1
    {
        private TennisGame tennisGame = new TennisGame("Joey", "Mei");

        [TestMethod]
        public void Love_all()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            GivenFirstPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScoreTimes(3);
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            tennisGame.SecondPlayerScore();
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            tennisGame.FirstPlayerScore();
            tennisGame.SecondPlayerScore();
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScoreTimes(2);
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce_when_3_3()
        {
            GivenFirstPlayerScoreTimes(3);
            GivenSecondPlayerScoreTimes(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_when_4_4()
        {
            GivenFirstPlayerScoreTimes(4);
            GivenSecondPlayerScoreTimes(4);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void FirstPlayer_win()
        {
            GivenFirstPlayerScoreTimes(4);
            ScoreShouldBe("Joey Win");
        }

        [TestMethod]
        public void SecondPlayer_win()
        {
            GivenSecondPlayerScoreTimes(4);
            ScoreShouldBe("Mei Win");
        }

        [TestMethod]
        public void FirstPlayer_Advance_when_4_3()
        {
            GivenFirstPlayerScoreTimes(4);
            GivenSecondPlayerScoreTimes(3);
            ScoreShouldBe("Joey Adv");
        }

        [TestMethod]
        public void FirstPlayer_Advance_when_6_5()
        {
            GivenFirstPlayerScoreTimes(6);
            GivenSecondPlayerScoreTimes(5);
            ScoreShouldBe("Joey Adv");
        }

        private void GivenSecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.SecondPlayerScore();
            }
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            string score = tennisGame.GetScore();
            Assert.AreEqual(expected, score);
        }
    }
}