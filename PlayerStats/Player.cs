using System;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;
        private readonly string name;

        public Player(string playerName)
        {
            this.name = playerName;
            this.highScore = 0f;
            this.playedGames = 0;
            this.wonGames = 0;
        }
        public float HighScore
        {
            get
            {
                return highScore;
            }
            set
            {
                if(value > highScore)
                    highScore = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public float WinRate
        {
            get
            {
                if(playedGames > 0)
                {
                    float winRate = (float) wonGames / (float) playedGames;
                    return winRate;
                }
                else
                    return 0f;
            }
        }

        public void PlayGame(bool win)
        {
            playedGames++;
            if(win)
            {
                wonGames++;
            }
        }
    }
}