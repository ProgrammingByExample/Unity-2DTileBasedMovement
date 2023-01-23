using UnityEngine;
using UnityEngine.Tilemaps;

namespace FQ.GridLevel.MapLoader.Unity
{
    /// <summary>
    /// Creates a tilemap from a resource.
    /// </summary>
    public interface ITilemapFromSingleLevel
    {
        /// <summary>
        /// Loads a tilemap from a resource.
        /// </summary>
        /// <param name="data"> A text based source assert for a single layer. </param>
        /// <returns> A tilemap representing the single level. </returns>
        Tilemap LoadFromASingleLevel(TextAsset data);
    }
}