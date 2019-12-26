/*
 * Copyright (C) 2012 GREE, Inc.
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty.  In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would be
 *    appreciated but is not required.
 * 2. Altered source versions must be plainly marked as such, and must not be
 *    misrepresented as being the original software.
 * 3. This notice may not be removed or altered from any source distribution.
 */

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SampleWebView : MonoBehaviour
{
    public string Url;
    public GUIText status;
    WebViewObject webViewObject;
    public Button btnGo;
    public Button btnGoBack;
    public InputField iFURL;
    IEnumerator Start()
    {
        btnGo = GameObject.Find("btnGo").GetComponent<Button>();
        btnGoBack = GameObject.Find("btnGoBack").GetComponent<Button>();
        btnGo.onClick.AddListener(delegate { btnGoClick(); });
        btnGoBack.onClick.AddListener(delegate { btnGoBackClick(); });
        iFURL = GameObject.Find("IFURL").GetComponent<InputField>();

        webViewObject = (new GameObject("WebViewObject")).AddComponent<WebViewObject>();
        webViewObject.Init(
            cb: (msg) =>
            {
                Debug.Log(string.Format("CallFromJS[{0}]", msg));
                status.text = msg;
                status.GetComponent<Animation>().Play();
            },
            err: (msg) =>
            {
                Debug.Log(string.Format("CallOnError[{0}]", msg));
                status.text = msg;
                status.GetComponent<Animation>().Play();
            },
            started: (msg) =>
            {
                Debug.Log(string.Format("CallOnStarted[{0}]", msg));
            },
            ld: (msg) =>
            {
                Debug.Log(string.Format("CallOnLoaded[{0}]", msg));
                webViewObject.EvaluateJS(@"Unity.call('ua=' + navigator.userAgent)");
            },
            //ua: "custom user agent string",
            enableWKWebView: true);
        webViewObject.SetMargins(Screen.width / 4, Screen.height / 4, Screen.width/4, Screen.height / 50);
        webViewObject.SetVisibility(true);
        //webViewObject.LoadURL("https://www.google.com/");
        
        //if (Url.StartsWith("http")) {
        //    webViewObject.LoadURL(Url.Replace(" ", "%20"));
        //} else {
        //    var exts = new string[]{
        //        ".jpg",
        //        ".js",
        //        ".html"  // should be last
        //    };
        //    foreach (var ext in exts) {
        //        var url = Url.Replace(".html", ext);
        //        var src = System.IO.Path.Combine(Application.streamingAssetsPath, url);
        //        var dst = System.IO.Path.Combine(Application.persistentDataPath, url);
        //        byte[] result = null;
        //        if (src.Contains("://")) {  // for Android
        //            var www = new WWW(src);
        //            yield return www;
        //            result = www.bytes;
        //        } else {
        //            result = System.IO.File.ReadAllBytes(src);
        //        }
        //        System.IO.File.WriteAllBytes(dst, result);
        //        if (ext == ".html") {
        //            webViewObject.LoadURL("file://" + dst.Replace(" ", "%20"));
        //            break;
        //        }
        //    }
        //}
        yield break;
    }

    public void btnGoClick()
    {
        webViewObject.LoadURL("http://"+iFURL.text);
    }
    public void btnGoBackClick()
    {
        if(webViewObject.CanGoBack())
        webViewObject.GoBack();
    }

    private void OnEnable()
    {
        webViewObject.SetVisibility(true);
    }

    private void OnDisable()
    {
        webViewObject.SetVisibility(false);
    }
}
