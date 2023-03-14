using BowlingBall.GameRules;
using BowlingBall.GameRules.Interfaces;
using BowlingBall.Handlers;
using BowlingBall.Handlers.Interfaces;
using BowlingBall.Helpers;
using BowlingBall.Helpers.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        private IRules _rule;
        private IFrameHelper _frameHelper;
        private IFrameFactory _frameFactory;

        private IGame _game;

        [TestInitialize]
        public void Initialize()
        {
            var rules = new Rules();

            _rule = new Rules();
            _frameHelper = new FrameHelper();
            _frameFactory = new FrameFactory(_rule);
            _game = new Game(_rule, _frameHelper, _frameFactory);
        }

        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            // Arrange
            var expectedScore = 0;
            Roll(_game, 0, 20);

            // Act
            var actualScore = _game.GetScore();

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        private void Roll(IGame game, int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
