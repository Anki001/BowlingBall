using BowlingBall.Common;
using BowlingBall.Common.Types;
using BowlingBall.GameRules.Interfaces;
using BowlingBall.Helpers;
using System.Collections.Generic;

namespace BowlingBall.GameRules
{
    public class Rules : IRules
    {
        public FrameType GetFrameType(IEnumerable<int> pins)
        {
            if (FrameHelper.IsStrike(pins))
                return FrameType.Strike;

            if (FrameHelper.IsSpare(pins))
                return FrameType.Spare;

            return FrameType.Open;
        }

        public int GetRollAllowedForCurrentFrame(int currentFrame, IEnumerable<int> pins)
        {
            if (!FrameHelper.IsLastFrame(currentFrame) && FrameHelper.IsStrike(pins))
                return Constants.MaxRollCountPerStrike;

            if (FrameHelper.IsLastFrame(currentFrame) && (FrameHelper.IsStrike(pins) || FrameHelper.IsSpare(pins)))
                return Constants.MaxRollCountLastFrame;

            return Constants.MaxRollCountPerFrame;
        }
    }
}
