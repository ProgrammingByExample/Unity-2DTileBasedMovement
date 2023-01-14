using FQ.GridLevel.Map;
using Moq;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;

namespace FQ.GridLevel.MapTests
{
    public class ActiveMapInfoTests
    {
        private IActiveMapInfo testClass;
        
        [SetUp]
        public void Setup()
        {
            testClass = new ActiveMapInfo();
        }

        [TearDown]
        public void Teardown()
        {
            
        }

        [Test]
        public void GetTileStateAt_ReturnsBlocked_WhenNoMapIsGivenTest()
        {
            // Arrange

            // Act
            EMapTileState actual = testClass.GetTileStateAt(0, 0, 0);

            // Assert
            Assert.AreEqual(EMapTileState.Blocked, actual);
        }
        
        [Test]
        public void GetTileStateAt_ReturnsBlocked_WhenGiveTerrainMapIsCalledButWithNullMapTest()
        {
            // Arrange
            var expected = EMapTileState.Blocked;
            testClass.GiveTerrainMap(null, 0, 0);

            // Act
            EMapTileState actual = testClass.GetTileStateAt(0, 0, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetTileStateAt_ReturnsOpen_WhenMapIsGivenWithOpenTileTest()
        {
            // Arrange
            var expected = EMapTileState.Open;
            var mockMovementMap = new Mock<IMovementMap>();
            mockMovementMap.Setup(x => x.GetTileStateAt(0,0,0)).Returns(expected);
            testClass.GiveTerrainMap(mockMovementMap.Object, 0, 0);

            // Act
            EMapTileState actual = testClass.GetTileStateAt(0, 0, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetTileStateAt_ReturnsOpen_WhenOffsetIsOneAndTestIsOneTest(
            [Values(-1, 0, 1)] int x,
            [Values(-1, 0, 1)] int z
            )
        {
            // Arrange
            var expected = EMapTileState.Open;
            var mockMovementMap = new Mock<IMovementMap>();
            mockMovementMap.Setup(x => x.GetTileStateAt(0,0,0)).Returns(expected);
            testClass.GiveTerrainMap(mockMovementMap.Object, x, z);

            // Act
            EMapTileState actual = testClass.GetTileStateAt(x, 0, z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetTileStateAt_ReturnsBlocked_WhenOffsetIsOneAndTestIsTwoTest(
            [Values(-1, 0, 1)] int x,
            [Values(-1, 0, 1)] int z
        )
        {
            // Arrange
            var expected = EMapTileState.Blocked;
            var mockMovementMap = new Mock<IMovementMap>();
            mockMovementMap.Setup(x => x.GetTileStateAt(0,0,0)).Returns(expected);
            testClass.GiveTerrainMap(mockMovementMap.Object, x, z);

            // Act
            EMapTileState actual = testClass.GetTileStateAt(x, 0, z);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
