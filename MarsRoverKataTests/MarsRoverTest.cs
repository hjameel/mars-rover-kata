using MarsRoverKata;
using NUnit.Framework;

namespace MarsRoverKataTests
{
	[TestFixture]
	public class MarsRoverTest
	{
		[Test]
		public void It_starts_at_the_point_given()
		{
			var startingPosition = new Position(5, 5);

			var rover = new MarsRover(startingPosition);
			Assert.That(rover.Position, Is.EqualTo(startingPosition));
		}
	}
}
