using BowlingBall.Handlers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Helpers.Interfaces
{
    public interface IFrameHelper
    {
        void SetNextFrame(IEnumerable<IFrame> frames, IFrame nextFrame);
    }
}
