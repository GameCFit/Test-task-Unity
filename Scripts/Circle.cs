using UnityEngine;

public class Circle : MonoBehaviour, ICircleControlbe, ICircleSpeedChenged
{
    public static Circle Instance;

    private float _speed;

    private Vector3 _targetPoint;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    private void FixedUpdate()
    {
        if (_targetPoint != new Vector3(0, 0, 0))
        {
            if (transform.position != _targetPoint)
            {
                Move();
            }
            else
            {
                _targetPoint = new Vector3(0, 0, 0);
            }
        }
    }

    public void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPoint, _speed);
    }

    public void SetMousePosition(Vector3 mousePositionVector)
    {
        _targetPoint = mousePositionVector;
    }

    public void SpeedChenged(float value)
    {
        _speed = value;
    }
}
