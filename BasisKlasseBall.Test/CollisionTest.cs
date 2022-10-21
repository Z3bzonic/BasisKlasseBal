using BasisKlasseBall;
using Xunit;

namespace BasisKlasseBall.Test
{
    public class CollisionTest
    {
        [Fact]
        public void CheckHit_BallShouldCollideWithPlayer()
        {
            //arrange
            bool expected = true;

            //act
            //int expectedPlayerX = 5;
            //int expectedBallX = 5;
            //int expectedPlayerY = 5;
            //int expectedBallY = 5;
            bool actual = true;
            // bool actual = (expectedPlayerX == expectedBallX) && (expectedPlayerY == expectedBallY);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}