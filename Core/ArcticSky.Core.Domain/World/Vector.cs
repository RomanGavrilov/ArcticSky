using System;

namespace ArcticSky.Core.Domain.World
{
    public struct Vector : IEquatable<Vector>
    {
        public Vector(int x, int y, int z) : this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public bool Equals(Vector other) => X == other.X && Y == other.Y && Z == other.Z;

        public Vector Inverse => new Vector(-X, -Y, -Z);
        public static Vector operator +(Vector a, Vector b) => new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector operator *(Vector a, Vector b) => new Vector(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Vector Identity => new Vector(1, 1, 1);
        public static Vector Zero => new Vector(0, 0, 0);
    }
}
