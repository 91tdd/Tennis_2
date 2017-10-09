namespace Tennis_2
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public string GetScore()
        {
            if (this._firstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            this._firstPlayerScoreTimes++;
        }
    }
}