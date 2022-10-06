using UnityEngine;

namespace Asteroids
{
    internal sealed class HealthManager : MonoBehaviour, IHealth
    {       
        public float Health { get; protected set; }

        public HealthManager(float hp)
        {
            Health = hp;
        }

        public void HealthAnalysis()
        {
            if (Health <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                Health--;
            }
        }
    }
}
