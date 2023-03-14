using BowlingBall.Common.Types;
using BowlingBall.Handlers.Interfaces;
using System.Collections.Generic;

namespace BowlingBall.Handlers
{
    public class FrameFactory : IFrameFactory
    {
        public IFrame CreateFrame(int frameIndex, IEnumerable<int> pins, FrameType frameType)
        {
            switch (frameType)
            {
                case FrameType.Spare:
                    return new SpareFrame(frameIndex, pins);
                case FrameType.Strike:
                    return new StrikeFrame(frameIndex, pins);
                case FrameType.Open:
                default:
                    return new Frame(frameIndex, pins);
            }
        }
    }
}
