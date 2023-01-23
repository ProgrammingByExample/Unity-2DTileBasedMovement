namespace FQ.GridLevel.MapLoader
{
    /// <summary>
    /// Unprocessed information for a given tileset.
    /// </summary>
    public interface ITilesetRaw
    {
        /// <summary>
        /// The number the first number which the tileset uses.
        /// </summary>
        int FirstGridTile { get; }

        /// <summary>
        /// The name of the tileset.
        /// </summary>
        string TilesetKey { get; }
    }
}