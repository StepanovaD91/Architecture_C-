using UnityEngine;

namespace Asteroids
{
    internal sealed class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed = 100.0f;
        [SerializeField] private float life = 5.0f;
        
        void Start()
        {
            Destroy(gameObject, life);
        }

        void Update()
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
