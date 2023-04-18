using UnityEngine;

namespace Tasks.Task6
{
    public class Level6 : MonoBehaviour
    {
        private float _speed = 5;

        private void Update()
        {
            var step = Time.deltaTime * _speed;
            var transformPosition = transform.position;
            transformPosition.x += step;

            transform.position = transformPosition; 
        }
    }
}