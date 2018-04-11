using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingInfo : Interaction
{

    public string Name;
 



    public override void Select()
    {
        InfoManager.Current.SetText(
            Name, "", GetComponent<Player>().Info.Name);
    }


    public override void Deselect()
    {
        InfoManager.Current.ClearText();
    }
}