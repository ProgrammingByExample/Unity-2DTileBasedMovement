using System;

namespace FQ.GridLevel.MapLoader.Tiled
{
    public class TiledMapInfo : ITilemapInfo
    {
        /// <summary>
        /// The version number for the map.
        /// </summary>
        public string FileVersion { get; }
        
        /// <summary>
        /// The width/height of pixels a single tile should be rendered.
        /// </summary>
        public int TilePixelWidthHeight { get; }
        
        /// <summary>
        /// The limit of a given map's size.
        /// </summary>
        public EMapSizeLimit MapSizeLimit { get; }
        
        /// <summary>
        /// The width and height of the tilemap in tiles.
        /// </summary>
        public int MapSizeWidthHeight { get; }

        public TiledMapInfo(string xmlData)
        {
            if (string.IsNullOrWhiteSpace(xmlData))
            {
                throw new ArgumentNullException(
                    $"{typeof(TiledMapInfo)}: {nameof(xmlData)} may not be null or empty.");
            }
        }
    }
}