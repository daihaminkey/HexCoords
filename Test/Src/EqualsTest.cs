using HexCoords;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class EqualsTest
    {
        [TestCase(0 ,0, 0)]
        [TestCase(2, 1, 0)]
        public void SameTypeSameValueEqualTest(int x, int y, int z)
        {
            Assert.AreEqual(new CubeCoord(x, y, z), new CubeCoord(x, y, z));
            Assert.AreEqual(new AxialCoord(x, y), new AxialCoord(x, y));
            Assert.AreEqual(new OffsetCoord(x, y), new OffsetCoord(x, y));
        }
        
        [TestCase(0 ,0, 0, 1, 1, 1)]
        [TestCase(2, 1, 0, -2, 1, -3)]
        public void SameTypeDifferentValueNotEqualTest(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            Assert.AreNotEqual(new CubeCoord(x1, y1, z1), new CubeCoord(x2, y2, z2));
            Assert.AreNotEqual(new AxialCoord(x1, y1), new AxialCoord(x2, y2));
            Assert.AreNotEqual(new OffsetCoord(x1, y1), new OffsetCoord(x2, y2));
        }

        [TestCase(0 ,0, 0, 0, 0, 0 ,0)]
        [TestCase(0, 2, -2, 0, -2, -1, -2)]
        [TestCase(2, -2, 0, 2, 0, 2, 0)]
        public void DifferentTypeSameValueEqualTest(int cubeX, int cubeY, int cubeZ, int axialQ, int axialR, int offsetX, int offsetY)
        {
            var cube = new CubeCoord(cubeX, cubeY, cubeZ);
            var axial = new AxialCoord(axialQ, axialR);
            var offset = new OffsetCoord(offsetX, offsetY);
            
            Assert.AreEqual(cube, axial);
            Assert.AreEqual(cube, offset);
            Assert.AreEqual(axial, offset);
        }
        
        [TestCase(0 ,2, -2, -1, 0, 2 ,2)]
        public void DifferentTypeDifferentValueNotEqualTest(int cubeX, int cubeY, int cubeZ, int axialQ, int axialR, int offsetX, int offsetY)
        {
            var cube = new CubeCoord(cubeX, cubeY, cubeZ);
            var axial = new AxialCoord(axialQ, axialR);
            var offset = new OffsetCoord(offsetX, offsetY);
            
            Assert.AreNotEqual(cube, axial);
            Assert.AreNotEqual(cube, offset);
            Assert.AreNotEqual(axial, offset);
        }
    }
}