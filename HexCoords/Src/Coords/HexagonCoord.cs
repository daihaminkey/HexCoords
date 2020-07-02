using System;

namespace HexCoords
{
    public abstract class HexagonCoord : IEquatable<HexagonCoord>
    {
        public abstract AxialCoord ToAxial();

        public abstract CubeCoord ToCube();

        public abstract OffsetCoord ToOffset();

        public bool Equals(HexagonCoord other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            
            return this.ToAxial().Equals(other.ToAxial());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            
            return Equals((HexagonCoord) obj);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}