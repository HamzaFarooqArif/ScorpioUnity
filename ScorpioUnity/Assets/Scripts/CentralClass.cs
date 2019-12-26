using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using UnityEngine;

public class CentralClass : MonoBehaviour
{
    public int ch1Min;
    public int ch1Max;
    public int ch2Min;
    public int ch2Max;

    public List<int> channelList;
    int chCount;
    bool isChUpdated;
    public string iPAddress;
    WebClient client;
    public bool isConnected;
    string response;

    void Start()
    {
        client = new WebClient();

        channelList = new List<int>();
        chCount = 2;
        for(int i = 0; i < chCount; i++)
        {
            channelList.Add(0);
        }
        isChUpdated = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isChUpdated)
        { 
            broadCastCh();
            isChUpdated = false;
        }
    }

    public void updateChannel(int idx, int val)
    {
        if(idx < chCount && channelList[idx] != val)
        {
            channelList[idx] = val;
            isChUpdated = true;
        }
    }

    public void broadCastCh()
    {
        PingAndSend();
    }
    public void PingAndSend()
    {
        StartCoroutine(StartPing(iPAddress));
    }
    IEnumerator StartPing(string ip)
    {
        WaitForSeconds f = new WaitForSeconds(0.05f);
        UnityEngine.Ping p = new UnityEngine.Ping(ip);
        while (p.isDone == false)
        {
            yield return f;
        }
        PingFinished(p);
    }
    public void PingFinished(UnityEngine.Ping p)
    {
        string queryString = "http://" + iPAddress + "/?";
        for (int i = 0; i < chCount; i++)
        {
            if (i + 1 == chCount)
            {
                queryString += i + "=" + channelList[i];
            }
            else
            {
                queryString += i + "=" + channelList[i] + "&";
            }
        }
        response = client.DownloadString(queryString);
    }
}
