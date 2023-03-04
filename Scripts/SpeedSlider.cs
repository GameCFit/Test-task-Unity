using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    private Slider _slider;

    private ICircleSpeedChenged _circleSpeedChenged;

    private void Start()
    {
        _circleSpeedChenged = Circle.Instance;
        _slider = GetComponent<Slider>();
    }

    public void ChangedSliderValue()
    {
        _circleSpeedChenged.SpeedChenged(_slider.value);
    }
}
