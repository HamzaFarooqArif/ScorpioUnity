using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ConfirmButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private CentralClass centralClass;
    private Button button;
    private InputField inputField;
    private InputField ch1Min;
    private InputField ch1Max;
    private InputField ch2Min;
    private InputField ch2Max;
    private Text txtConnect;
    public bool isConnected;
    private Ping ping;
    void Start()
    {
        centralClass = GameObject.Find("staticObject").GetComponent<CentralClass>();
        button = this.gameObject.GetComponent<Button>();
        inputField = GameObject.Find("IFIPAddress").GetComponent<InputField>();
        ch1Min = GameObject.Find("IFCh1Min").GetComponent<InputField>();
        ch1Max = GameObject.Find("IFCh1Max").GetComponent<InputField>();
        ch2Min = GameObject.Find("IFCh2Min").GetComponent<InputField>();
        ch2Max = GameObject.Find("IFCh2Max").GetComponent<InputField>();
        txtConnect = GameObject.Find("txtConnect").GetComponent<Text>();
        isConnected = false;

        inputField.text = "192.168.8.103";
        ch1Min.text = "-128";
        ch1Max.text = "127";
        ch2Min.text = "-128";
        ch2Max.text = "127";

    }

    // Update is called once per frame
    void Update()
    {
        if(ping.isDone)
        {
            centralClass.isConnected = true;
            txtConnect.text = "Connected";
        }
        else
        {
            centralClass.isConnected = false;
            txtConnect.text = "Not Connected";
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        centralClass.iPAddress = inputField.text;
        centralClass.ch1Min = Int32.Parse(ch1Min.text);
        centralClass.ch1Max = Int32.Parse(ch1Max.text);
        centralClass.ch2Min = Int32.Parse(ch2Min.text);
        centralClass.ch2Max = Int32.Parse(ch2Max.text);
        ping = new Ping(centralClass.iPAddress);
    }
    public void OnPointerUp(PointerEventData eventData)
    {

    }
}
