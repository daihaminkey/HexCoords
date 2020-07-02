using System;

namespace HexCoords
{
    public class AxialCoord : HexagonCoord, IEquatable<AxialCoord>
    {
        public int Q { get; set; }
        public int R { get; set; }
        
        public AxialCoord(int q, int r)
        {
            Q = q;
            R = r;
        }

        public override string ToString() => $"Axial Coord: [{Q}; {R}]";
        
        public override AxialCoord ToAxial() => new AxialCoord(Q, R);
        
        public override CubeCoord ToCube() => new CubeCoord(Q, -Q-R, R);

        public override OffsetCoord ToOffset() => new OffsetCoord(Q + (R - (R & 1)) / 2, R);

        public bool Equals(AxialCoord other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            
            return this.Q == other.Q && this.R == other.R;
        }
    }
}