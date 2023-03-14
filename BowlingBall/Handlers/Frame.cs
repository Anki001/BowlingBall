using BowlingBall.Handlers.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BowlingBall.Handlers
{
    public class Frame : IFrame
    {
        public int FrameIndex { get; set; }
        public int FrameScore { get; set; }
        public IEnumerable<int> Pins { get; set; }
        public IFrame NextFrame { get; set; }

        public Frame(int frameIndex, IEnumerable<int> pins)
        {
            FrameIndex = frameIndex;
            Pins = pins;
            FrameScore = pins.Sum();
        }
        public virtual int GetFramesScore()
        {
            return FrameScore;
        }
    }
}
