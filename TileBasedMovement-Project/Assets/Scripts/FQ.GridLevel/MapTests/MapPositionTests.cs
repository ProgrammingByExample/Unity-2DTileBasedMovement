using FQ.GridLevel.Map;
using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;

namespace FQ.GridLevel.MapTests
{
    public class MapPositionTests
    {
        private IMapPosition testClass;
        
        [SetUp]
        public void Setup()
        {
            testClass = new MapPosition();
        }

        [TearDown]
        public void Teardown()
        {
            
        }

        [Test]
        public void IsPositionWithinMap_ReturnsFalse_WhenNothingElseCalledTest()
        {
            // Arrange
            
            // Act
            bool actual = testClass.IsPositionWithinMap(x: 0, z: 0);

            // Assert
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void IsPositionWithinMap_ReturnsTrue_WhenSetSizeWidthOneHeightOneTest()
        {
            // Arrange
            testClass.SetSize(width: 1, height: 1);
            
            // Act
            bool actual = testClass.IsPositionWithinMap(x: 0, z: 0);

            // Assert
            Assert.IsTrue(actual);
        }
        
        [Test]
        public void IsPositionWithinMap_ReturnsFalse_WhenSetSizeHeightOneAndPositionIsXOneTest()
        {
            // Arrange
            testClass.SetSize(width: 0, height: 1);
            
            // Act
            bool actual = testClass.IsPositionWithinMap(x: 1, z: 0);

            // Assert
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void IsPositionWithinMap_ReturnsFalse_WhenSetSizeWidthOneAndPositionIsYOneTest()
        {
            // Arrange
            testClass.SetSize(width: 1, height: 0);
            
            // Act
            bool actual = testClass.IsPositionWithinMap(x: 0, z: 1);

            // Assert
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void IsPositionWithinMap_ReturnsFalse_WhenSizeIsOneAndPositionIsOneTest()
        {
            // Arrange
            testClass.SetSize(width: 1, height: 1);
            testClass.SetPosition(x: 1, z: 1);

            // Act
            bool actual = testClass.IsPositionWithinMap(x: 0, z: 0);

            // Assert
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void IsPositionWithinMap_ReturnsFalse_WhenSizeIsOneAndPositionXIsOneTest()
        {
            // Arrange
            testClass.SetSize(width: 1, height: 1);
            testClass.SetPosition(x: 1, z: 0);

            // Act
            bool actual = testClass.IsPositionWithinMap(x: 0, z: 0);

            // Assert
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void IsPositionWithinMap_ReturnsFalse_WhenSizeIsOneAndPositionZIsOneTest()
        {
            // Arrange
            testClass.SetSize(width: 1, height: 1);
            testClass.SetPosition(x: 0, z: 1);

            // Act
            bool actual = testClass.IsPositionWithinMap(x: 0, z: 0);

            // Assert
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void GetX_ReturnsX_WhenSetPositionXToValueTest(
            [Values(-3, -1, 0, 4, 10)] int x,
            [Values(-3, -1, 0, 4, 10)] int z
            )
        {
            // Arrange
            int expectedValue = x;
            testClass.SetPosition(x: expectedValue, z: z);

            // Act
            int actual = testClass.X;

            // Assert
            Assert.AreEqual(expectedValue, actual);
        }
        
        [Test]
        public void GetX_ReturnsZ_WhenSetPositionZToValueTest(
            [Values(-3, -1, 0, 4, 10)] int x,
            [Values(-3, -1, 0, 4, 10)] int z
            )
        {
            // Arrange
            int expectedValue = z;
            testClass.SetPosition(x: x, z: expectedValue);

            // Act
            int actual = testClass.Z;

            // Assert
            Assert.AreEqual(expectedValue, actual);
        }
    }
}