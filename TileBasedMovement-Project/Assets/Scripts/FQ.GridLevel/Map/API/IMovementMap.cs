namespace FQ.GridLevel.Map
{
    public interface IMovementMap
    {
        /// <summary>
        /// Gets the state of the tile in terms of movement.
        /// </summary>
        /// <param name="x"> Location X cord. 0 is left, gaining value to the right. </param>
        /// <param name="y"> Location Y cord. 0 is ground. </param>
        /// <param name="z"> Location Z cord. 0 is top, gaining value moving down. </param>
        /// <returns> The state of the tile in terms of movement at the given location. </returns>
        EMapTileState GetTileStateAt(int x, int y, int z);
    }
}