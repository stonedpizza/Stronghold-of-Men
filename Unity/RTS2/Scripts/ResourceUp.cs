using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceUp : MonoBehaviour {

    public float ResourcesUp = 1;
    private PlayerSetupDefinition player;


	// Use this for initialization
	void Start () {
        player = GetComponent<Player>().Info;
		
	}
	
	// Update is called once per frame
	void Update () {
        player.Credits += ResourcesUp * Time.deltaTime;
		
	}
}
