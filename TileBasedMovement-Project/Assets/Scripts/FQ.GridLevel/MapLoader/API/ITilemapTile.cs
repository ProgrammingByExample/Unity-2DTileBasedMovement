namespace FQ.GridLevel.MapLoader
{
    /// <summary>
    /// Represents a single tile
    /// </summary>
    public interface ITilemapTile
    {
        /// <summary>
        /// The value in the tileset
        /// </summary>
        int Value { get; }
        
        /// <summary>
        /// The value adjusted such that 0 is the first tile in the tileset.
        /// </summary>
        int TileSetValue { get; }
        
        /// <summary>
        /// The name of the tileset.
        /// </summary>
        string TilesetKey { get; }
    }
}