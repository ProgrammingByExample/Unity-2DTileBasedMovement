namespace FQ.GridLevel.MapLoader
{
    /// <summary>
    /// The limit of a given map's size.
    /// </summary>
    public enum EMapSizeLimit
    {
        /// <summary>
        /// The number of tiles does not change (width height).
        /// </summary>
        Fixed = 0,
        
        /// <summary>
        /// The grid size could be infinite.
        /// </summary>
        Infinite,
    }
}