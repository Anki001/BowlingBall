namespace BowlingBall.Common
{
    public class Constants
    {
        /// Maximum number of frame count per game
        public const int MaxFrameCount = 10;
        /// Maximum number of roll count for 10th frame
        public const int MaxRollCountLastFrame = 3;
        /// Maximum number of roll for per frame except 10th frame
        public const int MaxRollCountPerFrame = 2;
        /// Maximum number of roll per strike
        public const int MaxRollCountPerStrike = 1;
        /// Number of Spare bonus roll
        public const int SpareBonusRoll = 1;
        /// Number of Strike bonus roll
        public const int StrikeBonusRoll = 2;
        /// Total pins per roll
        public const int TotalPinsPerRoll = 10;
    }
}
