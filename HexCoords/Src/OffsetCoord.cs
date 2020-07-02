namespace HexCoords
{
    public class OffsetCoord : HexagonCoord
    {

        public int X { get; set; }
        public int Y { get; set; }
        
        public OffsetCoord(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"Offset Coord: [{X}; {Y}]";

        public override AxialCoord ToAxial()
        {
            var q = X - (Y - (Y & 1)) / 2;
            var r = Y;
            
            return new AxialCoord(q, r);
        }
        
        public override OffsetCoord ToOffset() => new OffsetCoord(X, Y);

        public override CubeCoord ToCube()
        {
            var x = X - (Y - (Y & 1)) / 2;
            var y = -x - Y;
            
            return new CubeCoord(x, y, Y);
        }
    }
}