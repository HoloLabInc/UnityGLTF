using System;

namespace GLTF.Math
{
	public struct Vector3Double : IEquatable<Vector3Double>
	{
		public static readonly Vector3Double Zero = new Vector3Double(0f, 0f, 0f);
		public static readonly Vector3Double One = new Vector3Double(1f, 1f, 1f);

		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }
		
		public Vector3Double(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}
		

		public Vector3Double(Vector3Double other)
		{
			X = other.X;
			Y = other.Y;
			Z = other.Z;
		}

		public bool Equals(Vector3Double other)
		{
			return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			return obj is Vector3Double && Equals((Vector3Double) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = X.GetHashCode();
				hashCode = (hashCode * 397) ^ Y.GetHashCode();
				hashCode = (hashCode * 397) ^ Z.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(Vector3Double left, Vector3Double right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(Vector3Double left, Vector3Double right)
		{
			return !left.Equals(right);
		}
	}
}
