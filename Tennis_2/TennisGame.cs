using System;
using System.Collections.Generic;

namespace Tennis_2
{
    public class TennisGame
    {
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;
        private int _firstPlayerScoreTimes;

        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
            {
                {0, "Love" },
                {1, "Fifteen" },
                {2, "Thirty" },
                {3, "Forty" },
            };

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public string GetScore()
        {
            if (IsDifferentScore())
            {
                return IsReadyForWin() ? AdvanceScore() : NormalScore();
            }

            return IsDeuce() ? "Deuce" : NormalAll();
        }

        private string NormalAll()
        {
            return scoreLookup[_firstPlayerScoreTimes] + " All";
        }

        private string NormalScore()
        {
            return scoreLookup[_firstPlayerScoreTimes] + " " + scoreLookup[_secondPlayerScoreTimes];
        }

        private string AdvanceScore()
        {
            var advancePlayer = AdvancePlayer();
            if (Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1)
            {
                return advancePlayer + " Adv";
            }

            return advancePlayer + " Win";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3;
        }

        private bool IsReadyForWin()
        {
            return _firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3;
        }

        private bool IsDifferentScore()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }

        private string AdvancePlayer()
        {
            return _firstPlayerScoreTimes > _secondPlayerScoreTimes
                ? _firstPlayerName
                : _secondPlayerName;
        }
    }
}