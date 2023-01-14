using System.Numerics;

namespace FQ.GridLevel.Map
{
    /// <summary>
    /// Defines a grid map position.
    /// </summary>
    public class MapPosition : IMapPosition
    {
        /// <summary>
        /// The size of the map.
        /// </summary>
        private Vector2 size;
        
        /// <summary>
        /// The position the map is in the larger map.
        /// </summary>
        private Vector2 position;

        public MapPosition()
        {
            size = new Vector2(-1, -1);
            position = new Vector2(0, 0);
        }
        
        /// <summary>
        /// The current X position within the map.
        /// </summary>
        public int X => (int)position.X;

        /// <summary>
        /// The current Z position within the map.
        /// </summary>
        public int Z => (int)position.Y;
        
        /// <summary>
        /// Determines if position is within map.
        /// </summary>
        /// <param name="x"> The x position to test. Left is small, gains size moving right. </param>
        /// <param name="z"> The z position to test. Top is small, gain size moving down. </param>
        /// <returns> True means position is within the map. </returns>
        public bool IsPositionWithinMap(int x, int z)
        {
            if (x < position.X)
            {
                return false;
            }
            
            if (x > position.X + size.X)
            {
                return false;
            }
            
            if (z < position.Y)
            {
                return false;
            }
            
            if (z > position.Y + size.Y)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Sets the top left position of the given map.
        /// </summary>
        /// <param name="x"> The new x position. Left is small, gains size moving right. </param>
        /// <param name="z"> The new z position. Top is small, gain size moving down. </param>
        public void SetPosition(int x, int z)
        {
            position.X = x;
            position.Y = z;
        }

        /// <summary>
        /// Sets the size of the map.
        /// </summary>
        /// <param name="width"> The width of the map. </param>
        /// <param name="height"> The height of the map. </param>
        public void SetSize(int width, int height)
        {
            size.X = width;
            size.Y = height;
        }
    }
}