using System;
using FQ.GridLevel.MapLoader.Tiled;
using NUnit.Framework;

namespace FQ.GridLevel.MapLoader.TiledTests
{
    [TestFixture]
    public class TiledTilemapInfoTests
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
        public void Construction_ArgumentNullException_GivenStringIsNullTests()
        {
            // Arrange
            string givenXML = null;

            // Act/Assert
            Assert.Throws<ArgumentNullException>
            (
            () => new TiledMapInfo(givenXML)
            );
        }
    }
}