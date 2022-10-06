using UnityEngine;

namespace Asteroids
{
    internal sealed class ShipWeapon : MonoBehaviour, IFire
    {
        private readonly Rigidbody2D _bullet;
        private readonly Transform _barrel;
        public float Force { get; protected set; }
    
        public ShipWeapon(Rigidbody2D rigidbody2D, Transform transform, float force)
        {
            _bullet = rigidbody2D;
            _barrel = transform;
            Force = force;
        }

        public void Fire()
        {
            var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * Force);
        }
    }
}