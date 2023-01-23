namespace FQ.GridLevel.MapLoader
{
    /// <summary>
    /// Holds overall information about the Tilemap.
    /// </summary>
    public interface ITilemapInfo
    {
        /// <summary>
        /// The version number for the map.
        /// </summary>
        string FileVersion { get; }
        
        /// <summary>
        /// The width/height of pixels a single tile should be rendered.
        /// </summary>
        int TilePixelWidthHeight { get; }
        
        /// <summary>
        /// The limit of a given map's size.
        /// </summary>
        EMapSizeLimit MapSizeLimit { get; }
        
        /// <summary>
        /// The width and height of the tilemap in tiles.
        /// </summary>
        int MapSizeWidthHeight { get; }
    }
}