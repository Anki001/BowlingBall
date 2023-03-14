using BowlingBall.Common;
using BowlingBall.Common.Types;
using BowlingBall.Helpers;
using BowlingBall.GameRules.Interfaces;
using System.Collections.Generic;

namespace BowlingBall.GameRules
{
    public class Rules : IRules
    {
        public FrameType GetFrameType(IEnumerable<int> pins)
        {
            if (FrameTypeHelper.IsStrike(pins))
                return FrameType.Strike;

            if (FrameTypeHelper.IsSpare(pins))
                return FrameType.Spare;

            return FrameType.Open;
        }

        public int GetRollAllowedForCurrentFrame(int currentFrame, IEnumerable<int> pins)
        {
            if (!FrameTypeHelper.IsLastFrame(currentFrame) && FrameTypeHelper.IsStrike(pins))
                return Constants.MaxRollCountPerStrike;

            if (FrameTypeHelper.IsLastFrame(currentFrame) && (FrameTypeHelper.IsStrike(pins) || FrameTypeHelper.IsSpare(pins)))
                return Constants.MaxRollCountLastFrame;

            return Constants.MaxRollCountPerFrame;
        }
    }
}
