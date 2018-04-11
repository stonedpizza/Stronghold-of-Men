using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public abstract class ActionBehavior : MonoBehaviour
{
    public abstract Action GetClickAction();
    public Sprite Buttonpic;
}



