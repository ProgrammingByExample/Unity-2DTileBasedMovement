using FQ.GridLevel.Map;
using NUnit.Framework;
using UnityEngine;

namespace FQ.GridLevel.MapTests
{
    public class ActiveMapInfoTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [TearDown]
        public void Teardown()
        {
            
        }

        [Test]
        public void GetTileStateAt_ReturnsBlocked_WhenNoMapIsGiven()
        {
            // Arrange
            IActiveMapInfo testClass = new ActiveMapInfo();

            // Act
            EMapTileState actual = testClass.GetTileStateAt(0, 0, 0);

            // Assert
            Assert.AreEqual(EMapTileState.Blocked, actual);
        }
    }
}
