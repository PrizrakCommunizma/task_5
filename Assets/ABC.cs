using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ABC : MonoBehaviour
{
    public Text label;
    public InputField FName, Name;
    public Image img;
    [System.Obsolete]
    void Start()
    {
        //StartCoroutine(SendGetRequest("-"));
    }

    private string SendGetRequest(string v)
    {
        throw new NotImplementedException();
    }

    [System.Obsolete]
    IEnumerator GetImage(string ur1)
    {
        Texture2D texture1 = null;
        WWW www = new WWW(ur1);
        yield return www;
        texture1 = www.texture;
        img.GetComponent<Image>().sprite.texture = texture1;
    }

    [System.Obsolete]
    IEnumerator SendPostRequest(string ur1)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(ur1);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            label.text += "\nError: " + uwr.error;
        }
        else
        {
            label.text += "\nReceived: " + uwr.downloadHandler.text;
        }
        yield return new WaitForSeconds(5);
        StartCoroutine(SendGetRequest("-"));
    }

    [System.Obsolete]
    IEnumerator SendPostRequest(string ur1)
    {
        WWWForm form = new WWWForm();
        form.AddField("Firstname", FName.text);
        form.AddField("Name", Name.text);

        UnityWebRequest uwr = UnityWebRequest.Get(ur1);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            label.text += "\nError: " + uwr.error;
        }
        else
        {
            label.text += "\nReceived: " + uwr.downloadHandler.text;
        }
    }
    public void send_Button()
    {
        StartCoroutine(SendGetRequest("-"));
    }
}
