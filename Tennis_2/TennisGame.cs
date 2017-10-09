using System.Collections.Generic;

namespace Tennis_2
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
            {
                {1, "Fifteen" },
                {2, "Thirty" },
                {3, "Forty" },
            };

        private int _secondPlayerScoreTimes;

        public string GetScore()
        {
            if (_firstPlayerScoreTimes > 0)
            {
                return scoreLookup[_firstPlayerScoreTimes] + " Love";
            }

            if (_secondPlayerScoreTimes > 0)
            {
                return "Love " + scoreLookup[_secondPlayerScoreTimes];
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}