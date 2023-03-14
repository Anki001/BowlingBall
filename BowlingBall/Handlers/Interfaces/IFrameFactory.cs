using System.Collections.Generic;

namespace BowlingBall.Handlers.Interfaces
{
    public interface IFrameFactory
    {
        IFrame CreateFrame(int frameIndex, IEnumerable<int> pins);
    }
}
