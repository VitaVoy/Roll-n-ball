using UnityEngine;

namespace Geekbrains
{   
    public sealed partial class PlayerBall : Player
    {
        partial void Test();

        private void FixedUpdate()
        {    
            Move();
            Jump();
            Test();
            test = 0;
            GetSpeed();
            Speed1 = 10;
        }              

        public override void GetJump()
        {
        
        }

        public override void Start()
        {
            base.Start();

            _rigidbody.AddForce(Vector3.zero);
        }

        private void Update()
        {
            
        }

        private int t { get; set; }

        public void ChangeSpeed(float speed)
        {
            if (Speed1 == 10)
            {
                Speed1 = speed;
            }
                
        }

    }
   
}
