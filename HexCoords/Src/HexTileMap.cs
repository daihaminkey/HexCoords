using System;

namespace HexCoords
{
    public class HexTileMap<TTileData>
    {
        private readonly TTileData[,] _data;

        public readonly int Width;
        public readonly int Height;
        
        public HexTileMap(int width, int height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("HexTileMap must be at least 1x1");
            
            _data = new TTileData[width, height];
            Width = width;
            Height = height;
        }

        public TTileData this[int x, int y]
        {
            get => _data[x, y];
            set => _data[x, y] = value;
        }

        public TTileData this[OffsetCoord offset]
        {
            get => this[offset.X, offset.Y];
            set => this[offset.X, offset.Y] = value;
        }

        public TTileData this[HexagonCoord hex]
        {
            get => this[hex.ToOffset()];
            set => this[hex.ToOffset()] = value;
        }
    }
}