using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAffordance : MonoBehaviour 
{
    [SerializeField] Texture2D walkCursor = null, targetCursor = null, unknownCursor = null;
    [SerializeField] Vector2 cursorHotspot = new Vector2(100, 0);

    CameraRaycaster cameraRaycaster;

	// Use this for initialization
	void Start () 
    {
        cameraRaycaster = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void Update()
    {
        switch (cameraRaycaster.layerHit)
        {
            case Layer.Enemy:
                Cursor.SetCursor(targetCursor, cursorHotspot, CursorMode.Auto);
                break;
            case Layer.Walkable:
                Cursor.SetCursor(walkCursor, cursorHotspot, CursorMode.Auto);
                break;
            case Layer.RaycastEndStop:
                Cursor.SetCursor(unknownCursor, cursorHotspot, CursorMode.Auto);
                break;
            default:
                Debug.Log("Don't know what cursor to show.");
                break;
        }
    }
}
