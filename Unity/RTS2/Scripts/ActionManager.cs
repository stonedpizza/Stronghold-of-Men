
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ActionManager : MonoBehaviour
{

    public static ActionManager Current;

    public Button [] Buttons;

    private List<Action> actionUse = new List<Action>();
  public ActionManager ()
    {
        Current = this;
    }
    public void ClearButtons()
    {
        foreach (var b in Buttons)
            b.gameObject.SetActive(false);

        actionUse.Clear();

    }

    public void AddButton(Sprite pic, Action onClick)
    {
        int index = actionUse.Count;
        Buttons [index].gameObject.SetActive(true);
        Buttons [index].GetComponent<Image>().sprite = pic;
        actionUse.Add(onClick);

    }
    public void OnButtonClick(int index)

    {
        actionUse [index]() ;
       
    }



    // Use this for initialiPuzation
    void Start()
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            var index = i;
            Buttons[index].onClick.AddListener(delegate ()
            {
                OnButtonClick(index);
            });
            
        }
        ClearButtons();

    }


}

