using BowlingBall.Common.Types;
using BowlingBall.GameRules.Interfaces;
using BowlingBall.Handlers.Interfaces;
using System.Collections.Generic;

namespace BowlingBall.Handlers
{
    public class FrameFactory: IFrameFactory
    {
        private readonly IRules _rule;

        public FrameFactory(IRules rule)
        {
            _rule = rule;
        }

        public IFrame CreateFrame(int frameIndex, IEnumerable<int> pins)
        {
            var frameType = _rule.GetFrameType(pins);

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
