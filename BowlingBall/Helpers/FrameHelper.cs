using BowlingBall.Handlers.Interfaces;
using BowlingBall.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Helpers
{
    public class FrameHelper : IFrameHelper
    {
        public void SetNextFrame(IEnumerable<IFrame> frames, IFrame nextFrame)
        {
            if (!frames.Any() || frames.LastOrDefault() == null || nextFrame == null) return;

            frames.Last().NextFrame = nextFrame;
        }
    }
}
