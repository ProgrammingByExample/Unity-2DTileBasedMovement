namespace FQ.GridLevel.Map
{
    /// <summary>
    /// The state of the tile in terms of movement.
    /// </summary>
    public enum EMapTileState
    {
        /// <summary>
        /// Movement is not possible.
        /// </summary>
        Blocked = 0,
        
        /// <summary>
        /// A new entity may enter
        /// </summary>
        Open,
    }
}