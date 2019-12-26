using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControlSliderScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Slider slider;
    CentralClass centralClass;
    public int value;
    void Start()
    {
        centralClass = GameObject.Find("staticObject").GetComponent<CentralClass>();
        
        slider = this.gameObject.GetComponent<Slider>();
        if (slider.name.Equals("LRSlider"))
        {
            slider.minValue = centralClass.ch1Min;
            slider.maxValue = centralClass.ch1Max;
        }
        else if (slider.name.Equals("FBSlider"))
        {
            slider.minValue = centralClass.ch2Min;
            slider.maxValue = centralClass.ch2Max;
        }
        slider.value = (slider.minValue + slider.maxValue) / 2;
        slider.onValueChanged.AddListener(delegate { OnValueChanged(); });
    }
    void Update()
    {

    }

    public void OnEnable()
    {
        if (slider.name.Equals("LRSlider"))
        {
            slider.minValue = centralClass.ch1Min;
            slider.maxValue = centralClass.ch1Max;
        }
        else if (slider.name.Equals("FBSlider"))
        {
            slider.minValue = centralClass.ch2Min;
            slider.maxValue = centralClass.ch2Max;
        }
        
    }

    public void OnValueChanged()
    {
        if(slider.name.Equals("LRSlider"))
        {
            centralClass.updateChannel(0, (int)slider.value);
        }
        else if (slider.name.Equals("FBSlider"))
        {
            centralClass.updateChannel(1, (int)slider.value);
        }

        //Debug.Log(this.gameObject.name + " " + slider.value);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log(this.gameObject.name + " Was Clicked.");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        slider.value = (slider.minValue + slider.maxValue)/2;
        if (slider.name.Equals("LRSlider"))
        {
            centralClass.updateChannel(0, (int)slider.value);
        }
        else if (slider.name.Equals("FBSlider"))
        {
            centralClass.updateChannel(1, (int)slider.value);
        }
    }

}
