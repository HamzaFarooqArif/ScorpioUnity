using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    CentralClass centralClass;
    private Button button;
    void Start()
    {
        centralClass = GameObject.Find("staticObject").GetComponent<CentralClass>();
        button = this.gameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(this.gameObject.name.Equals("btnLeft"))
        {
            centralClass.updateChannel(0, centralClass.ch1Min);
        }
        else if (this.gameObject.name.Equals("btnRight"))
        {
            centralClass.updateChannel(0, centralClass.ch1Max);
        }
        else if (this.gameObject.name.Equals("btnFwd"))
        {
            centralClass.updateChannel(1, centralClass.ch2Max);
        }
        else if (this.gameObject.name.Equals("btnBack"))
        {
            centralClass.updateChannel(1, centralClass.ch2Min);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (this.gameObject.name.Equals("btnLeft"))
        {
            centralClass.updateChannel(0, (centralClass.ch1Min + centralClass.ch1Max)/2);
        }
        else if (this.gameObject.name.Equals("btnRight"))
        {
            centralClass.updateChannel(0, (centralClass.ch1Min + centralClass.ch1Max) / 2);
        }
        else if (this.gameObject.name.Equals("btnFwd"))
        {
            centralClass.updateChannel(1, (centralClass.ch2Min + centralClass.ch2Max) / 2);
        }
        else if (this.gameObject.name.Equals("btnBack"))
        {
            centralClass.updateChannel(1, (centralClass.ch2Min + centralClass.ch2Max) / 2);
        }
    }
}
