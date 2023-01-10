namespace FQ.GridLevel.Map
{
    /// <summary>
    /// Gathers the information about a given map and the entities within the map.
    /// </summary>
    public class ActiveMapInfo : IActiveMapInfo
    {
        /// <summary>
        /// Gets the state of the tile in terms of movement.
        /// </summary>
        /// <param name="x"> Location X cord. 0 is left, gaining value to the right. </param>
        /// <param name="y"> Location Y cord. 0 is ground. </param>
        /// <param name="z"> Location Z cord. 0 is top, gaining value moving down. </param>
        /// <returns> The state of the tile in terms of movement at the given location. </returns>
        public EMapTileState GetTileStateAt(int x, int y, int z)
        {
            return EMapTileState.Blocked;
        }
    }
}