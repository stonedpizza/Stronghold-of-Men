﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RightClickNavigator : Interaction {

    public float RelaxDistance = 5;
    private NavMeshAgent agent;
    private Vector3 target = Vector3.zero;
    private bool selected = false;
    private bool IsActive = false;


    public override void Deselect()

    {
        selected = false;

    }
    public override void Select()
    {
        selected = true;
    }
    public void SendToTarget()
    {
        agent.SetDestination(target);
        agent.isStopped = false;
        IsActive = true;
    }
    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if (selected && Input.GetMouseButtonDown(1))
        {
            var tempTarget = RtsManager.Current.ScreenPointToMapPosition(Input.mousePosition);
            if (tempTarget.HasValue)
            {
                target = tempTarget.Value;
                SendToTarget();

            }
        }
        if ( IsActive && Vector3.Distance(target, transform.position) < RelaxDistance)
                {
            agent.isStopped = true;
            IsActive = false;
        }
	}
}
