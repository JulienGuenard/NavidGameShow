using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class CameraBound : MonoBehaviour {

void OnMouseOver ()
{
      Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition));
}
}
