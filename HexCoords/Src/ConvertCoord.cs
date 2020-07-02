namespace HexCoords
{
    public static class ConvertCoord
    {
        public static CubeCoord ToCube(OffsetCoord offset)
        {
            var x = offset.X - (offset.Y - (offset.Y & 1)) / 2;
            var z = offset.Y;
            var y = -x - z;
            
            return new CubeCoord(x, y, z);
        }
    }
}