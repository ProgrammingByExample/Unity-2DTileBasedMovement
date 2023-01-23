using UnityEngine;
using UnityEngine.Tilemaps;

namespace FQ.GridLevel.MapLoader.Unity
{
    /// <summary>
    /// Creates a set of tilemaps based on a resource.
    /// </summary>
    public class TilemapFromAllLayers : ITilemapFromAllLayers
    {
        /// <summary>
        /// Loads a set of tilemaps from a resource.
        /// </summary>
        /// <param name="data"> A text based source assert for a several layers. </param>
        /// <returns> An array of tilemaps representing the whole level. </returns>
        public Tilemap[] LoadFromMultipleLevels(TextAsset data)
        {
            throw new System.NotImplementedException();
        }
    }
}