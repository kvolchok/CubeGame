using System;
using UnityEngine;

namespace Tasks.Task4
{
    public class Level4 : MonoBehaviour
    {
        public bool UseGravity = true;
        private float _speed = 5;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.useGravity = UseGravity;
        }

        private void Update()
        {
            var step = Time.deltaTime * _speed;
            var transformPosition = transform.position;
            transformPosition.x += step;

            transform.position = transformPosition; 
        }
    }
}