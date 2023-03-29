using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpringySlider : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {
        slider = this.GetComponent<Slider>();
    }

    private void Update()
    {
        if (!Input.GetMouseButton(0))
        {
            slider.value = 0;
        }
    }
}
