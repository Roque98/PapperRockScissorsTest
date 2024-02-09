
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Text;

namespace RockPapperScissors.Test
{
    [TestFixture]
    public class GameTest
    {
        [TestFixture]
        public class getTextForIntro
        {
            [Test]
            public void GivenInitalValues_ShouldTextForIntro()
            {
                // Arrenged
                var expected =
                $"Title of game: Papper, rock and scissors" + "\n" +
                 "\n" +
                $"Total games: 0" + "\n" +
                $"Total win games: 0" + "\n" +
                $"Percent win games: 0" + "\n" +
                $"Total rounds: 0" + "\n" +
                $"Total win rounds: 0" + "\n" +
                $"Perecent win rounds: 0" + "\n" +
                 "\n" +
                $"Press Enter to start new game o Escape to exit.";


                var sut = new Game();

                // Act
                var actual = sut.getTextForIntro();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }


        [TestFixture]
        public class getTextForRequestNumberOfRoudsWinToFinishGame
        {
            [Test]
            public void GivenInitalValues_ShouldTextForRequestNumberOfRoudsWinToFinishGame()
            {
                // Arrenged
                var expected = $"Press the number of rounds to win the game 0";

                // Act
                var sut = new Game();

                // Eval
                var actual = sut.getTextForRequestNumberOfRoudsWinToFinishGame();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestFixture]
        public class getTextForConfirmConfigurationToGame
        {
            [Test]
            public void GivenInitalValues_ShouldTextForConfirmConfigurationToGame()
            {
                // Arrenged
                var expected =
                    $"You have selected 0 rounds to win the game 0. Its that okay?" + "\n" +
                    $"Press one option:" + "\n" +
                    $"\t1) Yes" + "\n" +
                    $"\t2) No";

                // Act
                var sut = new Game();

                // Eval
                var actual = sut.getTextForConfirmConfigurationToGame();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestFixture]
        public class getTextForTheRoundScreen
        {
            [Test]
            public void GivenInitalValues_ShouldgetTextForTheRoundScreen()
            {
                // Arrenged
                var expected =
                    $"Next screen(Start the ROUND):" + "\n" +
                    $"Round 0" + "\n" +
                    $"" + "\n" +
                    $"Number of rounds won" + "\n" +
                    $"You: 0" + "\n" +
                    $"opponent: 0" + "\n" +
                    $"" + "\n" +
                    $"Choice your next move:" + "\n" +
                    $"\t1). Paper" + "\n" +
                    $"\t2). Rock" + "\n" +
                    $"\t3). Scissors";

                // Act
                var sut = new Game();

                // Eval
                var actual = sut.getTextForTheRoundScreen();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }

        public class getTextForTheResultOfMovement
        {
            [Test]
            public void GivenInitalValues_ShouldGetTextForTheResultOfMovement()
            {
                // Arrenged
                var expected =
                    $"Your choice: Paper" + "\n" +
                    $"The opponent random choice: Paper" + "\n" +
                    $"" + "\n" +
                    $"Anyone's won. It's a tie" + "\n" +
                    $"" + "\n" +
                    $"Press any key to start the next round.";

                // Act
                var sut = new Game();

                // Eval
                var actual = sut.getTextForTheResultOfMovement();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }

    
}

/*

First screen (Start o exit):

    Intro message:
    
    Total games: N
    Total win games: N
    Percent win games: N
    Total rounds: N
    Total win rounds: N
    Percent win rounds: N
    
    Press Enter to start new game o Escape to exit.


Next screen (configure a game):
    Press the number of rounds to win the game N: 

Next screen (confirm your selection):    
    You have selected 5 rounds to win the game N. Its that okay?
    Press the correct option: 
        1) Yes
        2) No

Next screen (Start the ROUND):
    Round N 

    Number of rounds won
    You: N
    opponent: N

    Choice your next move:
        1). Paper
        2). Rock
        3). Scissors

    Your choice: N
    The opponent random choice: N

    (The opponent are wins) / (You win) / (Anyone's won. It's a tie)

    Press any key to start the next round


Next screen (End the game):
    YOU WIN THE GAME NUMBER N!
    CONGRATULATIONS!

    or

    The opponent wins the game numer n!
    Better luck next time for the next game.
*/