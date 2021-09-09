
using UnityEngine;

namespace Geekbrains
{
    public class SlowSpeed : MonoBehaviour
    {
        [SerializeField]
        private float _speed;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<PlayerBall>().ChangeSpeed(_speed);
            }
        }
    }
}
