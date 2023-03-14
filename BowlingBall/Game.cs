using BowlingBall.GameRules.Interfaces;
using BowlingBall.Handlers.Interfaces;
using BowlingBall.Helpers.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BowlingBall
{
    public class Game: IGame
    {
        private readonly IRules _rule;
        private readonly IFrameHelper _frameHelper;
        private readonly IFrameFactory _frameFactory;

        private List<IFrame> _frames;
        private List<int> _pinsForCurrentFrame;
        private int _frameCouter = 1;
        private int _rollsForCurrentFarme = 1;

        public Game(){ }

        public Game(IRules rule, IFrameHelper frameHelper, IFrameFactory frameFactory)
        {
            _rule = rule;
            _frameHelper = frameHelper;
            _frameFactory = frameFactory;
            _frames = new List<IFrame>();
            _pinsForCurrentFrame = new List<int>();
        }
        public void Roll(int pins)
        {
            // Add your logic here. Add classes as needed.
            _pinsForCurrentFrame.Add(pins);

            if (_rollsForCurrentFarme == _rule.GetRollAllowedForCurrentFrame(_frameCouter, _pinsForCurrentFrame))
            {
                var frameType = _rule.GetFrameType(_pinsForCurrentFrame);

                var nextFrame = _frameFactory.CreateFrame(_frameCouter, _pinsForCurrentFrame, frameType);

                _frameHelper.SetNextFrame(_frames, nextFrame);
                _frames.Add(nextFrame);

                InitializeNextFrame();
            }
            else
            {
                _rollsForCurrentFarme++;
            }
        }

        public int GetScore()
        {
            // Returns the final score of the game.
            var score = 0;

            if (!_frames.Any()) return score;

            foreach (var frame in _frames)
            {
                score = score + frame.GetFramesScore();
            }
            return score;
        }

        private void InitializeNextFrame()
        {
            _frameCouter++;
            _rollsForCurrentFarme = 1;
            _pinsForCurrentFrame = new List<int>();
        }

    }
}
