namespace MarsRoverKata
{
	public class MarsRover
	{
		public MarsRover(Position startingPosition)
		{
			Position = startingPosition;
		}

		public Position Position { get; private set; }
	}
}