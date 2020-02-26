using UnityEngine;

namespace MLAgents
{
    /// <summary>
    /// A component for 2D Ray Perception.
    /// </summary>
    [AddComponentMenu("ML Agents/Ray Perception Sensor 2D", (int)MenuGroup.Sensors)]
    public class RayPerceptionSensorComponent2D : RayPerceptionSensorComponentBase
    {
        /// <summary>
        /// Initializes the raycast sensor component.
        /// </summary>
        public RayPerceptionSensorComponent2D()
        {
            // Set to the 2D defaults (just in case they ever diverge).
            rayLayerMask = Physics2D.DefaultRaycastLayers;
        }

        /// <inheritdoc/>
        public override RayPerceptionCastType GetCastType()
        {
            return RayPerceptionCastType.Cast2D;
        }
    }
}
