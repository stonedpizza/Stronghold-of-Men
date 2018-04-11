using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOperator : MonoBehaviour {

    public Texture2D selectionHighlight = null;
    public static Rect selection = new Rect(0, 0, 0, 0);
    private Vector3 startclick = -Vector3.one;
	void Update () {
        checkCamera();
	}
    private void checkCamera()
    {
        if (Input.GetMouseButtonDown(0))
            startclick = Input.mousePosition;
        else if (Input.GetMouseButtonUp(0))
        {
            if (selection.width <0)
            {
                selection.x += selection.height;
                selection.width = -selection.width;
                

            }
            if (selection.height < 0)
            {
                selection.y += selection.height;
                selection.height = -selection.height;
            }
            startclick = -Vector3.one;
        }
        if (Input.GetMouseButton(0))
            selection = new Rect(startclick.x, InvertMouseY(startclick.y), Input.mousePosition.x - startclick.x, InvertMouseY(Input.mousePosition.y) - InvertMouseY(startclick.y));
    }
    public static float InvertMouseY(float y)
    {
        return Screen.height - y;
    }
}
