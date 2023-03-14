using BowlingBall.Common;
using BowlingBall.Handlers.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BowlingBall.Helpers
{
    public class FrameHelper
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

        public static void SetNextFrame(IEnumerable<IFrame> frames, IFrame nextFrame)
        {
            if (!frames.Any() || frames.LastOrDefault() == null || nextFrame == null) return;

            frames.Last().NextFrame = nextFrame;
        }
    }
}
