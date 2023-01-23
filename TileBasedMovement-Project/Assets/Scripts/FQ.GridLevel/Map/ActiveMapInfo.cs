using System;
using System.Collections.Generic;

namespace FQ.GridLevel.Map
{
    /// <summary>
    /// Gathers the information about a given map and the entities within the map.
    /// </summary>
    public class ActiveMapInfo : IActiveMapInfo
    {
        /// <summary>
        /// Maps with terrain upon them which does not change.
        /// </summary>
        private readonly List<Tuple<IMapPosition, IMovementMap>> terrainMaps;

        public ActiveMapInfo()
        {
            this.terrainMaps = new List<Tuple<IMapPosition, IMovementMap>>();
        }

        /// <summary>
        /// Gets the state of the tile in terms of movement.
        /// </summary>
        /// <param name="x"> Location X cord. 0 is left, gaining value to the right. </param>
        /// <param name="y"> Location Y cord. 0 is ground. </param>
        /// <param name="z"> Location Z cord. 0 is top, gaining value moving down. </param>
        /// <returns> The state of the tile in terms of movement at the given location. </returns>
        public EMapTileState GetTileStateAt(int x, int y, int z)
        {
            var tileState = EMapTileState.Blocked;
            for (int i = 0; i < this.terrainMaps.Count; ++i)
            {
                Tuple<IMapPosition, IMovementMap> mapCouple = this.terrainMaps[i];
                int offsetX = mapCouple.Item1.X;
                int offsetZ = mapCouple.Item1.Z;
                tileState = mapCouple.Item2.GetTileStateAt(x - offsetX, y, z - offsetZ);
            }

            return tileState;
        }

        /// <summary>
        /// Adds a new movement map map at the given location (top left location).
        /// </summary>
        /// <param name="movementMap"> A map of static tiles which do not change. </param>
        /// <param name="x"> Location X cord. 0 is left, gaining value to the right. </param>
        /// <param name="z"> Location Z cord. 0 is top, gaining value moving down. </param>
        public void GiveMovementMap(IMovementMap movementMap, int x, int z)
        {
            if (movementMap == null)
            {
                return;
            }
            
            IMapPosition position = new MapPosition();
            position.SetPosition(x, z);
            position.SetSize(Int32.MaxValue - x, Int32.MaxValue - z);
            
            this.terrainMaps.Add(new Tuple<IMapPosition, IMovementMap>(position, movementMap));
        }
    }
}