using BowlingBall.Common;
using BowlingBall.Common.Extensions;
using System.Collections.Generic;

namespace BowlingBall.Handlers
{
    public class StrikeFrame : Frame
    {
        internal StrikeFrame(int frameIndex, IEnumerable<int> pins) : base(frameIndex, pins) { }

        public override int GetFramesScore()
        {
            return this.GetBonusScore(Constants.StrikeBonusRoll, FrameScore);
        }
    }
}
