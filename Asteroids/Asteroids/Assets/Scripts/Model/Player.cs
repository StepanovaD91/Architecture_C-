using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        private Camera _camera;
        private Ship _ship;
        private ShipWeapon _shipWeapon;
        private HealthManager _healthManager;
      
        
       
        private void Start()
        {
            _camera = Camera.main;
            var _moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            var _rotation = new RotationShip(transform);
            _ship = new Ship(_moveTransform, _rotation);
            _shipWeapon = new ShipWeapon(_bullet, _barrel, _force);
            _healthManager = new HealthManager(_hp);
            
        }

        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);

            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);
           
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }

            if (Input.GetButton("Fire1"))
            {
                _shipWeapon.Fire();
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _healthManager.HealthAnalysis();
        }

    }
}