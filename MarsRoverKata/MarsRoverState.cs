using System.Linq;
using System.Security.Claims;

namespace MarsRoverKata
{
	public class MarsRoverState
	{
		private readonly char _direction;
		private readonly Position _position;

		public MarsRoverState(Position startingPosition, char direction)
		{
			_position = startingPosition;
			_direction = direction;
		}

		public char Direction
		{
			get { return _direction; }
		}

		public Position Position
		{
			get { return _position; }
		}

		public MarsRoverState Move(params char[] commands)
		{
			if (commands.Length == 0)
			{
				return this;
			}

			return new MarsRoverState(
				new Position(
					_position.X,commands[0] == 'F' ? _position.Y + 1 : _position.Y - 1), _direction)
					.Move(commands.Skip(1).ToArray());
		}
	}
}