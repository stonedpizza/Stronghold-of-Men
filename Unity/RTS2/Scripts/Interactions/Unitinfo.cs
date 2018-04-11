using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unitinfo : Interaction
{
    public string Name;
    public float MaxHp , CurrentHp;



    public override void Select()
    {
        InfoManager.Current.SetText(
            Name, CurrentHp + "/" + MaxHp ,GetComponent<Player>().Info.Name);
    }


    public override void Deselect()
    {
        InfoManager.Current.ClearText();
    }















}