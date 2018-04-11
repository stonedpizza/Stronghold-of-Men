using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CreateBuildingAction : ActionBehavior
{
    public float Cost = 0;
    public GameObject Building;
    public float MaxbuildingDistance = 100;
    public GameObject GhostBuilding;
        private GameObject active = null;

    public override Action GetClickAction()
    {
        return delegate () {
            var player = GetComponent<Player>().Info;
            if (player.Credits < Cost)
            {

                Debug.Log("need more resources");
                return;
            }
            var go = GameObject.Instantiate(GhostBuilding);
            var finder = go.AddComponent<BuildingSite>();
            finder.Building = Building;
            finder.Info = player;
            finder.Source = transform;
            active = go;
            };
    }
    private void Update()
    {
        if (active == null)
            return;
        if (Input.GetKeyDown(KeyCode.Escape))
            GameObject.Destroy(active);
    }
    private void OnDestroy()
    {
        if (active == null)
            return;
        Destroy(active);
    }

}





