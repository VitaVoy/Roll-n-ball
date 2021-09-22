using System;
using UnityEngine;

namespace Geekbrains
{
    public class Score : MonoBehaviour
    {
        public int _score = 0;

        [SerializeField]
        private GameObject _exit;

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 100, 100), "Score: " + _score);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Coin"))
            {
                _score++;
            }
            else
            {
                throw new MyException("Ничего не нашел");               
            }
        }
        public sealed class MyException : Exception
        {            
            public MyException(string message) : base (message)
            {               
            }
        }

    }
}
