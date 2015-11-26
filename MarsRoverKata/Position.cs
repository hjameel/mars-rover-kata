﻿namespace MarsRoverKata
{
	public sealed class Position
	{
		public int X { get; private set; }
		public int Y { get; private set; }

		public Position(int x, int y)
		{
			X = x;
			Y = y;
		}

		private bool Equals(Position other)
		{
			return X == other.X && Y == other.Y;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return obj is Position && Equals((Position) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (X*397) ^ Y;
			}
		}
	}
}