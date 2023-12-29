using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SampleSlider : Slider ,IPointerDownHandler ,IPointerUpHandler 
{
    public Action<PointerEventData> OnSliderPointerDown;
    public Action<PointerEventData> OnSliderPointerUp;
    // Start is called before the first frame update
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        OnSliderPointerDown?.Invoke(eventData);
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        OnSliderPointerUp?.Invoke(eventData);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
