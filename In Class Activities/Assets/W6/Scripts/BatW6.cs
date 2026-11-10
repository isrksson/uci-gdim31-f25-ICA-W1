using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private int speed = 1;
    private bool _isChasing = false;
    private Vector3 _targetPosition;

    private void Update()
    {
        if (_isChasing)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, step);
        }
    }
    public void startChasing(Vector3 playerPosition)
    {
        _targetPosition = playerPosition;
        _isChasing = true;
    }

    public void stopChasing()
    {
        _isChasing = false;
    }
}
