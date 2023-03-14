using BowlingBall.Common.Types;
using System.Collections.Generic;

namespace BowlingBall.Rules.Interfaces
{
    public interface IRules
    {        
        FrameType GetFrameType(IEnumerable<int> pins);
        int GetRollAllowedForCurrentFrame(int currentFrame, IEnumerable<int> pins);
    }
}
