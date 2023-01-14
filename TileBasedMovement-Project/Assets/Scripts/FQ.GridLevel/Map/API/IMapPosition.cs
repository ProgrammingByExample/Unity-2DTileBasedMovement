namespace FQ.GridLevel.Map
{
    /// <summary>
    /// Defines a grid map position.
    /// </summary>
    public interface IMapPosition
    {
        /// <summary>
        /// The current X position within the map.
        /// </summary>
        int X { get; }
        
        /// <summary>
        /// The current Z position within the map.
        /// </summary>
        int Z { get; }
        
        /// <summary>
        /// Determines if position is within map.
        /// </summary>
        /// <param name="x"> The x position to test. Left is small, gains size moving right. </param>
        /// <param name="z"> The z position to test. Top is small, gain size moving down. </param>
        /// <returns> True means position is within the map. </returns>
        bool IsPositionWithinMap(int x, int z);
        
        /// <summary>
        /// Sets the top left position of the given map.
        /// </summary>
        /// <param name="x"> The new x position. Left is small, gains size moving right. </param>
        /// <param name="z"> The new z position. Top is small, gain size moving down. </param>
        void SetPosition(int x, int z);

        /// <summary>
        /// Sets the size of the map.
        /// </summary>
        /// <param name="width"> The width of the map. </param>
        /// <param name="height"> The height of the map. </param>
        void SetSize(int width, int height);
    }
}