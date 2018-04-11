using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManager : MonoBehaviour {

    public static InfoManager Current;

    public Image ProfilePic;
    public Text Text1, Text2, Text3;

    public InfoManager ()
    {
        Current = this;
    }

    public void SetText(string text1, string text2, string text3)
    {
        Text1.text = text1;
        Text2.text = text2;
        Text3.text = text3; 
    }
    public void ClearText()
    {
        SetText("", "", "");
    }
    public void SetPic(Sprite pic)
    {
        ProfilePic.sprite = pic;
        ProfilePic.color = Color.white;
    }


	// Use this for initialization
	void Start () {
        ClearText();
      
		
	}
	
}
