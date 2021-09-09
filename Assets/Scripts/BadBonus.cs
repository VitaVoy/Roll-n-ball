using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class BadBonus : InteractiveObject, IRotation, IFly, IFlicker
    {
        private Material _material;
        private float _flyHeight;
        protected override void Interaction()
        {

        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                                                    Mathf.PingPong(Time.time, _flyHeight),
                                                    transform.localPosition.z);
        }

        public void Rotation()
        {
        }
    }
}