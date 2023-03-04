using UnityEngine;

public class Mouse : MonoBehaviour
{
    private ICircleControlbe _circleControlbe;

    private Vector3 _mousePosition;

    private void Start()
    {
        _circleControlbe = Circle.Instance;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _circleControlbe.SetMousePosition(_mousePosition);
        }
    }
}
