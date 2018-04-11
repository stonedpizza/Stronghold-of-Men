using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{

    public Text ResourceText;


    // Update is called once per frame
    void Update()
    {
        ResourceText.text = "Resources:  " + (int)Player.Default.Credits;

    }
}