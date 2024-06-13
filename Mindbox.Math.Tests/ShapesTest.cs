using Mindbox.Math.Shapes;

namespace Mindbox.Math.Tests
{
    [TestClass]
    public class ShapesTest
    {
        /// <summary>
        /// General test for value consistency
        /// </summary>
        [TestMethod]
        public void Circle_Area_Should()
        {
            //Arrange
            double expected = 314.1592653589793;
            int radius = 10;
            Circle c = new Circle(radius);

            //Act
            var actual = c.Area;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for negative number check
        /// </summary>
        [TestMethod]
        public void Circle_Area_Negative_Should()
        {
            //Arrange
            int radius = -5;

            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }
        
        /// <summary>
        /// Test for zero number check (must return 0)
        /// </summary>
        [TestMethod]
        public void Circle_Area_Zero_Should()
        {
            //Arrange
            double expected = 0;
            int radius = 0;
            Circle c = new Circle(radius);

            //Act
            var actual = c.Area;

            //Assert
            Assert.AreEqual(expected, actual);
        }



        /// <summary>
        /// General test for value consistency
        /// </summary>
        [TestMethod]
        public void Triangle_Area_Should()
        {
            //Arrange
            double expected = 6;
            int a = 3;
            float b = 4;
            int c = 5;
            Triangle t = new Triangle(a, b, c);

            //Act
            var actual = t.Area;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for zero number check (must return 0)
        /// </summary>
        [TestMethod]
        public void Triangle_Area_Zero_Should()
        {
            //Arrange
            double expected = 0;
            int a = 0;
            float b = 0;
            int c = 0;
            Triangle t = new Triangle(a, b, c);

            //Act
            var actual = t.Area;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for negative number check
        /// </summary>
        [TestMethod]
        public void Triangle_Area_Negative_Should()
        {
            //Arrange
            int a = -5;
            float b = 0;
            int c = 0;

            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a,b,c));
        }

    }
}