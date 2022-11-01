using UnityEngine;
namespace Asteroids
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        private void Start()
        {
            var gameObjectBuilder = new GameObjectBuilder();
            GameObject player = gameObjectBuilder.Visual.Name("Bullet").Sprite(_sprite).Physics.Rigidbody2D(5).BoxCollider2D();
        }
    }
}
