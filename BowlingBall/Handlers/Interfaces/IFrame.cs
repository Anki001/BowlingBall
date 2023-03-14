using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Handlers.Interfaces
{
    public interface IFrame
    {
        int FrameIndex { get; set; }
        int FrameScore { get; set; }
        IEnumerable<int> Pins { get; set; }
        IFrame NextFrame { get; set; }
        int GetFramesScore();
    }
}
