using BowlingBall.GameRules;
using BowlingBall.GameRules.Interfaces;
using BowlingBall.Handlers;
using BowlingBall.Handlers.Interfaces;
using BowlingBall.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        private IRules _rule;        
        private IFrameFactory _frameFactory;

        private IGame _game;

        [TestInitialize]
        public void Initialize()
        {
            var rules = new Rules();

            _rule = new Rules();            
            _frameFactory = new FrameFactory();
            _game = new Game(_rule, _frameFactory);
        }

        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            // Arrange
            var expectedScore = 0;
            Roll(0, 20);

            // Act
            var actualScore = _game.GetScore();

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void Game_If_Random_Score_For_All_Frame_Then_Score_Should_Be_Valid()
        {
            // Arrangee
            var expectedScore = 187;

            // Act            
            _game.Roll(10);
            _game.Roll(9);

            _game.Roll(1);
            _game.Roll(5);

            _game.Roll(5);
            _game.Roll(7);

            _game.Roll(2);
            _game.Roll(10);

            _game.Roll(10);
            _game.Roll(10);

            _game.Roll(9);
            _game.Roll(0);

            _game.Roll(8);
            _game.Roll(2);

            _game.Roll(9);
            _game.Roll(1);
            _game.Roll(10);

            var actualScore = _game.GetScore();

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void Game_If_Strike_For_All_Frame_Then_Score_Should_Be_300()
        {
            // Arrangee
            var expectedScore = 300;
            Roll(10, 12);

            // Act
            var actualScore = _game.GetScore();

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void Game_If_Spare_For_All_Frame_Then_Score_Should_Be_150()
        {
            // Arrangee
            var expectedScore = 150;
            Roll(5, 21);

            // Act
            var actualScore = _game.GetScore();

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void Game_If_Alternate_Spare_And_Strike_Frame_Then_Score_Should_Be_200()
        {
            // Arrangee
            var expectedScore = 200;

            Roll(5, 2);
            Roll(10, 1);

            Roll(5, 2);
            Roll(10, 1);

            Roll(5, 2);
            Roll(10, 1);

            Roll(5, 2);
            Roll(10, 1);

            Roll(5, 2);
            Roll(10, 1);
            Roll(5, 2);

            // Act
            var actualScore = _game.GetScore();

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        private void Roll(int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                _game.Roll(pins);
            }
        }
    }
}
