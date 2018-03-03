using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ControllerBuild : MonoBehaviour {

public static ControllerBuild Instance;

    void Awake ()
    {
    Instance = this;
    }

	void Update () 
    {

    RaycastHit hit;
		if (Input.GetKeyDown(KeyCode.Mouse0))
        {
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
              PullingManager.Instance.Build(hit.point + new Vector3 (0,transform.localScale.y/2,0), typeBuilding.Barrack);
            }  
        }
	}
}
