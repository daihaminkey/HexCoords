using HexCoords;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class TileMapTests
    {
        [Test]
        public void InitTest()
        {
            var map = new HexTileMap<int>(1, 1);
            
            Assert.AreEqual(1, map.Width);
            Assert.AreEqual(1, map.Height);
        }

        [Test]
        public void ReadWriteByCoord()
        {
            var axial = new AxialCoord(-1, +2);
            var map = new HexTileMap<int>(5, 5);

            int expectedValue = 3;
            map[axial] = expectedValue;
            
            Assert.AreEqual(expectedValue, map[axial]);
            Assert.AreEqual(expectedValue, map[axial.ToOffset()]);
            Assert.AreEqual(expectedValue, map[axial.ToCube()]);
        }
    }

}