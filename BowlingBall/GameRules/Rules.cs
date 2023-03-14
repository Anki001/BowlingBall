using BowlingBall.Common;
using BowlingBall.Common.Types;
using BowlingBall.Helpers;
using BowlingBall.GameRules.Interfaces;
using System.Collections.Generic;

namespace BowlingBall.GameRules
{
    public class Rules : IRules
    {        
        //private int MaxFrameCount_M = 10;        
        //private int MaxRollCountLastFrame_M = 3;        
        //private int MaxRollCountPerFrame_M = 2;        
        //private int MaxRollCountPerStrike_M = 1;        
        //private int SpareBonusRoll_M = 1;        
        //private int StrikeBonusRoll_M = 2;        
        //private int TotalPinsPerRoll_M = 10;

        //public int MaxFrameCount { get{return MaxFrameCount_M; }; set{;}; }
        //public int MaxRollCountLastFrame { get{ return MaxRollCountLastFrame_M; }; set{;}; }
        //public int MaxRollCountPerFrame { get{return MaxRollCountPerFrame_M; }; set{;}; }
        //public int MaxRollCountPerStrike { get{return MaxRollCountPerStrike_M; }; set{;}; }
        //public int SpareBonusRoll { get{return SpareBonusRoll_M; }; set{;}; }
        //public int StrikeBonusRoll { get{return StrikeBonusRoll_M; }; set{;}; }
        //public int TotalPinsPerRoll { get{return TotalPinsPerRoll_M; }; set{;}; }

        public FrameType GetFrameType(IEnumerable<int> pins)
        {
            if (FrameTypeHelper.IsStrike(pins))
                return FrameType.Strike;

            if (FrameTypeHelper.IsSpare(pins))
                return FrameType.Spare;

            return FrameType.Open;
        }

        public int GetRollAllowedForCurrentFrame(int currentFrame, IEnumerable<int> pins)
        {
            if (!FrameTypeHelper.IsLastFrame(currentFrame) && FrameTypeHelper.IsStrike(pins))
                return Constants.MaxRollCountPerStrike;

            if (FrameTypeHelper.IsStrike(pins) || FrameTypeHelper.IsSpare(pins))
                return Constants.MaxRollCountLastFrame;

            return Constants.MaxRollCountPerFrame;
        }
    }
}
