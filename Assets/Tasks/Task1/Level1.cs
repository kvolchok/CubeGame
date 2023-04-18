using UnityEngine;

namespace Tasks.Task1
{
    public class Level1 : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 0;
    
        private void Update()
        {
            var step = Time.deltaTime * _speed;
            var transformPosition = transform.position;
            transformPosition.x += step;

            transform.position = transformPosition;
        }
    }
}