using System;

namespace Tests.Rrs.ObjectCompare
{
    struct AStruct : IEquatable<AStruct>
    {
        public readonly int Left;
        public readonly int Right;

        public AStruct(int left, int right)
        {
            Left = left;
            Right = right;
        }

        public override bool Equals(object obj)
        {
            return obj is AStruct && this == (AStruct)obj;
        }

        public override int GetHashCode()
        {
            return Left.GetHashCode() ^ Right.GetHashCode();
        }

        public bool Equals(AStruct other)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(AStruct a, AStruct b)
        {
            return a.Left == b.Left && a.Right == b.Right;
        }

        public static bool operator !=(AStruct a, AStruct b)
        {
            return !(a == b);
        }
    }
}
