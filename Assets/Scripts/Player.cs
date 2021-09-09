using UnityEngine;

namespace Geekbrains
{
    public abstract class Player : MonoBehaviour
    {
        const float test0001 = 6.0f;
        static int test00;
        private float Speed = 3.0f;
        public Rigidbody _rigidbody;
        internal float test = 0;
        private float t1;


        public float Speed1
        {
            get
            {
                return Speed;
            }

            set
            {
                if (value > 1 && value <= 100)
                {
                    Speed = value;
                }
                else
                {
                    Speed = 1;
                }

            }
        }

        public static float Test0001 => Test00011;

        public static float Test00011 => test0001;

        internal float T1 { get; set; }

        public abstract void GetJump();


        public float GetSpeed()
        {
            return Speed;
        }

        public virtual void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal * -1, 0.0f, moveVertical * -1);

            _rigidbody.AddForce(movement * Speed1);
        }

       

    }
}
