using GetArea;

namespace TestArea
{
    public class UnitTest1
    {
        [Fact]
        public void GetCircleArea_WhenRadiusOk()
        {
            // Arrange
            var circle = new Circle(1.6);

            // Act
            var area = Math.Round(circle.GetArea(), 3);
            var universalArea = Math.Round(new GetAreaUniversal(new Circle(1.6)).Result(), 3);

            // Assert
            Assert.Equal(8.042, area);
            Assert.Equal(8.042, universalArea);
        }

        [Fact]
        public void GetTriangleArea_WhenSidesOk()
        {
            // Arrange
            var triangle = new Triangle(1.4, 2.0 , 2.5);
            var triangleRightAngled = new Triangle(3.0, 4.0, 5.0);
            // Act
            var area = Math.Round(triangle.GetArea(), 3);
            var universalArea = Math.Round(new GetAreaUniversal(new Triangle(1.4, 2.0, 2.5)).Result(), 3);

            // Assert
            Assert.Equal(1.398, area);
            Assert.Equal(1.398, universalArea);

            Assert.False(triangle.IsRightAngled());
            Assert.True(triangleRightAngled.IsRightAngled());
        }

        [Fact]
        public void SetCircle_WhenRadiusNegative()
        {
            try
            {
                var circle = new Circle(-1.6);
            }
            catch (Exception ex)
            {

                Assert.Equal("Радиус должен быть больше нуля", ex.Message);
            }
        }

        [Fact]
        public void SetTriangle_WhenSidesNegative()
        {
            try
            {
                var triangle = new Triangle(-1.4, 2.0, 2.5);
            }
            catch (Exception ex)
            {

                Assert.Equal("Сторона должна быть больше нуля", ex.Message);
            }
        }

        [Fact]
        public void SetTriangle_WhenSideGreterThenOther()
        {
            try
            {
                var triangle = new Triangle(1.4, 2.0, 5);
            }
            catch (Exception ex)
            {

                Assert.Equal("Сумма двух сторон треугольника всегда должна быть больше третьей", ex.Message);
            }
        }
    }
}