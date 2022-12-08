using System;

namespace Unit05.Game.Casting
{
    public class Powerup : Food
    {
        private int points = 0;

        public Powerup()
        {
            SetText("%");
            SetColor(Constants.WHITE);
            Reset();
        }

        
    }
}
