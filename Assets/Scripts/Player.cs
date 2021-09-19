using UnityEngine;

namespace Geekbrains
{
    public abstract class Player : MonoBehaviour
    {
        public float Speed = 5.0f;
        public Rigidbody _rigidbody;             

        public virtual void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal * -1, 0.0f, moveVertical * -1);

            _rigidbody.AddForce(movement * Speed);
        }

       

    }
}
