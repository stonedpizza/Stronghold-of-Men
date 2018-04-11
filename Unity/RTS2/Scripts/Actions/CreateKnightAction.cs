using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateKnightAction : ActionBehavior {

    public GameObject Knight;
    public float Cost = 50;
    private PlayerSetupDefinition player;

	// Use this for initialization
	void Start () {
        player = GetComponent<Player>().Info;

		
	}
    public override Action GetClickAction()
    {
        return delegate ()
        {
            if (player.Credits < Cost)
            {
                Debug.Log("not enough resources");
                return;
            }
            var go = (GameObject)GameObject.Instantiate(
                Knight,
                transform.position,
                Quaternion.identity);
            go.AddComponent<Player>().Info = player;
            player.Credits -= Cost;

        };
       
    }
}
