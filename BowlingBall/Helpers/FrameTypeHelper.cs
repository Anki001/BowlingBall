using BowlingBall.Common;
using BowlingBall.Handlers.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BowlingBall.Helpers
{
    public class FrameTypeHelper
    {
        public static bool IsLastFrame(int currentFrame)
        {
            return currentFrame == Constants.MaxFrameCount;
        }

        public static bool IsSpare(IEnumerable<int> pins)
        {
            return pins.Count() >= Constants.MaxRollCountPerFrame && pins.Take(Constants.MaxRollCountPerFrame).Sum() == Constants.TotalPinsPerRoll;
        }

        public static bool IsStrike(IEnumerable<int> pins)
        {
            return pins.Any() && pins.First() == Constants.TotalPinsPerRoll;
        }
    }
}
