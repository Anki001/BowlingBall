using BowlingBall.Handlers.Interfaces;

namespace BowlingBall.Common.Extensions
{
    public static class BonusScoreCalculator
    {
        public static int GetBonusScore(this IFrame frame, int bonusRollCount, int totalFrameScore, int bonusRollUsed = 0)
        {
            var nextFrame = frame.NextFrame;

            if (nextFrame == null) return totalFrameScore;

            foreach (var pins in nextFrame.Pins)
            {
                if (bonusRollUsed >= bonusRollCount)
                {
                    break;
                }
                else
                {
                    totalFrameScore = totalFrameScore + pins;
                    bonusRollUsed++;
                }
            }

            if (bonusRollUsed == bonusRollCount) return totalFrameScore;

            return nextFrame.GetBonusScore(bonusRollCount, totalFrameScore, bonusRollUsed);
        }
    }
}
