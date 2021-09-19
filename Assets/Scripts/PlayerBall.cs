using UnityEngine;

namespace Geekbrains
{   
    public sealed partial class PlayerBall : Player
    {
       
        private void FixedUpdate()
        {    
            Move();            
        }                       
        public override void Start()
        {
            base.Start();

            _rigidbody.AddForce(Vector3.zero);
        }

        private void Update()
        {
            
        }       

        public void ChangeSpeed(float _speed)
        {
            Speed = _speed;
        }

    }
   
}
