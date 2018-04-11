using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSite : MonoBehaviour
{

    public float Cost = 200;
    Renderer rend;
    Color Red = new Color(1, 0, 0, 0.5f);
    Color Greem = new Color(0, 1, 0, 0.5f);
    public float MaxBuildingdistance = 100;
    public GameObject Building;
    public PlayerSetupDefinition Info;
    public Transform Source;

    private void Start()
    {
        MouseManager.Current.enabled = false;
        rend = GetComponent<Renderer>();
    }



    // Update is called once per frame
    void Update()
    {
        var tempTarget = RtsManager.Current.ScreenPointToMapPosition(Input.mousePosition);
        if (tempTarget.HasValue == false)
            return;
        transform.position = tempTarget.Value;

        if(Vector3.Distance(transform.position,Source.position) > MaxBuildingdistance )
        {
            rend.material.color = Red;
            return;
        }
        if(RtsManager.Current.IsGameObjectSaveToPlace(gameObject))
        {
            rend.material.color = Greem;
            if(Input.GetMouseButtonDown(0))
            {
                var go = GameObject.Instantiate(Building);
                go.transform.position = transform.position;
                Info.Credits -= Cost;
                go.AddComponent<Player>().Info = Info ;
                Destroy(this.gameObject);
            }
            
        }
        else
        {
            rend.material.color = Red;
        }

    }
    private void OnDestroy()
    {
        MouseManager.Current.enabled = true;
    }
}
