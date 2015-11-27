using MarsRoverKata;
using NUnit.Framework;

namespace MarsRoverKataTests
{
	[TestFixture]
	public class MarsRoverStateTest
	{
		private const char Forward = 'F';
		private const char Backward = 'B';
		private const char North = 'N';

		[Test]
		public void It_starts_at_the_point_given()
		{
			var startingPosition = new Position(5, 5);

			var rover = new MarsRoverState(startingPosition, North);
			Assert.That(rover.Position, Is.EqualTo(startingPosition));
			Assert.That(rover.Direction, Is.EqualTo(North));
		}

		[Test]
		public void It_should_move_forward()
		{
			var startingPosition = new Position(0,0);

			var rover = new MarsRoverState(startingPosition, North);
			var movedRover = rover.Move(Forward);

			Assert.That(movedRover.Position, Is.EqualTo(new Position(0, 1)));
		}

		[TestCase(0,0,2)]
		[TestCase(0,1,3)]
		[TestCase(1,1,3)]
		public void It_should_move_two_forward(int x, int y, int finalY)
		{
			var startingPosition = new Position(x,y);

			var rover = new MarsRoverState(startingPosition, North);

			var movedRover = rover.Move(Forward, Forward);

			Assert.That(movedRover.Position, Is.EqualTo(new Position(x,finalY)));
		}

		[Test]
		public void It_should_move_backward()
		{
			var startingPosition = new Position(0,0);

			var rover = new MarsRoverState(startingPosition, North);
			var movedRover = rover.Move(Backward);

			Assert.That(movedRover.Position, Is.EqualTo(new Position(0, -1)));
		}

		[TestCase(0,0,-2)]
		[TestCase(0,3,1)]
		[TestCase(1,3,1)]
		public void It_should_move_two_backward(int x, int y, int finalY)
		{
			var startingPosition = new Position(x, y);

			var rover = new MarsRoverState(startingPosition, North);
			var movedRover = rover.Move(Backward, Backward);

			Assert.That(movedRover.Position, Is.EqualTo(new Position(x, finalY)));
		}

		[Test]
		public void It_should_move_forwards_then_backwards()
		{
			var startingPosition = new Position(0, 0);
			
			var rover = new MarsRoverState(startingPosition, North);
			var movedRover = rover.Move(Forward, Backward);

			Assert.That(movedRover.Position, Is.EqualTo(startingPosition));
		}
	}
}
