using HexCoords;
using NUnit.Framework;

 namespace Test
 {
     [TestFixture]
     public class ConversionTests
     {
         [TestCase(0, 0, 0, 0, 0)]
         [TestCase(0, -2, 0, 2, -2)]
         [TestCase(-1, 2, -1, -1, 2)]
         public void AxialToCubeTest(int q, int r, int expectedX, int expectedY, int expectedZ)
         {
             var axial = new AxialCoord(q, r);
             var cube = axial.ToCube();

             Assert.AreEqual(expectedX, cube.X);
             Assert.AreEqual(expectedY, cube.Y);
             Assert.AreEqual(expectedZ, cube.Z);
         }
         
         [TestCase( 0, 0, 0, 0, 0)]
         [TestCase( 0, 2, -2, 0, -2)]
         [TestCase(-1, -1, 2, -1, 2)]
         public void CubeToAxialTest(int x, int y, int z, int expectedQ, int expectedR)
         {
             var cube = new CubeCoord(x, y, z);
             var axial = cube.ToAxial();

             Assert.AreEqual(expectedQ, axial.Q);
             Assert.AreEqual(expectedR, axial.R);
         }
        
         [TestCase(0, 0, 0, 0, 0)]
         [TestCase(2, 0, 2, -2, 0)]
         [TestCase(-2, 2, -3, 1, 2)]
         public void OffsetToCubeTest(int x, int y, int expectedX, int expectedY, int expectedZ)
         {
             var offset = new OffsetCoord(x, y);
             var cube = offset.ToCube();

             Assert.AreEqual(expectedX, cube.X);
             Assert.AreEqual(expectedY, cube.Y);
             Assert.AreEqual(expectedZ, cube.Z);
         }

         [TestCase(0, 0, 0, 0, 0)]
         [TestCase(2, -2, 0, 2, 0)]
         [TestCase(-3, 1, 2, -2, 2)]
         public void CubeToOffsetTest(int x, int y, int z, int expectedX, int expectedY)
         {
             var cube = new CubeCoord(x, y, z);
             var offset = cube.ToOffset();
             
             Assert.AreEqual(expectedX, offset.X);
             Assert.AreEqual(expectedY, offset.Y);
         }
        
         [TestCase(0, 0, 0, 0)]
         [TestCase(+2, 0, +2, 0)]
         [TestCase(0, -2, -1, -2)]
         public void AxialToOffset(int q, int r, int expectedX, int expectedY)
         {
             var axial = new AxialCoord(q, r);
             var offset = axial.ToOffset();
             
             Assert.AreEqual(expectedX, offset.X);
             Assert.AreEqual(expectedY, offset.Y);
         }
         
         [TestCase(0, 0, 0, 0)]
         [TestCase(+2, 0, +2, 0)]
         [TestCase(-1, -2, 0, -2)]
         public void OffsetToAxial(int x, int y, int expectedQ, int expectedR)
         {
             var offset = new OffsetCoord(x, y);
             var axial = offset.ToAxial();
             
             Assert.AreEqual(expectedQ, axial.Q);
             Assert.AreEqual(expectedR, axial.R);
         }
     }
 }