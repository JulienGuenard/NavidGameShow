using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ControllerBuild : MonoBehaviour {

public static ControllerBuild Instance;

GameObject rootCamera;

    void Awake ()
    {
    Instance = this;

      rootCamera = GameObject.Find("rootCamera");
    }

	void Update () 
    {
      Debug.Log(Input.mousePosition);

      if (Input.GetKeyDown(KeyCode.Mouse0))
      BuildAtCurseur();

      if (Input.GetKey(KeyCode.Mouse1))
      MoveCamera();


	}

    void BuildAtCurseur ()
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

    void MoveCamera ()
    {
      rootCamera.transform.position += new Vector3(Input.GetAxis("Mouse Y") + Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y") - Input.GetAxis("Mouse X"));
    }

  public void MoveCameraAtBound ()
    {
      rootCamera.transform.position += new Vector3(Input.GetAxis("Mouse Y") + Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y") - Input.GetAxis("Mouse X"));
    }
}
