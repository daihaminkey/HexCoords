namespace HexCoords
{
    public class CubeCoord : HexagonCoord
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public CubeCoord(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString() => $"Cube Coord: [{X}; {Y}; {Z}]";

        public override AxialCoord ToAxial() => new AxialCoord(X, Z);
        
        public override OffsetCoord ToOffset() => new OffsetCoord(X + (Z - (Z & 1)) / 2, Z);
        
        public override CubeCoord ToCube() => new CubeCoord(X, Z, Z);
        
    }
}