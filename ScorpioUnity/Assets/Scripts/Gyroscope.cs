using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Gyroscope : MonoBehaviour, IPointerDownHandler
{
    private Button btnEnableGyro;
    private Text yaw;
    private Text pitch;
    private Text roll;
    
    void Start()
    {
        btnEnableGyro = this.gameObject.GetComponent<Button>();
        yaw = GameObject.Find("txtYaw").GetComponent<Text>();
        pitch = GameObject.Find("txtPitch").GetComponent<Text>();
        roll = GameObject.Find("txtRoll").GetComponent<Text>();
    }
    void Update()
    {
        if (Input.gyro.enabled)
        {
            yaw.text = GyroToUnity(Input.gyro.attitude).eulerAngles.x.ToString();
            pitch.text = GyroToUnity(Input.gyro.attitude).eulerAngles.y.ToString();
            roll.text = GyroToUnity(Input.gyro.attitude).eulerAngles.z.ToString();
            //transform.rotation = GyroToUnity(Input.gyro.attitude);
        }
    }

    private Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }
    }
}
