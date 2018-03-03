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
      
      if (Input.GetKeyDown(KeyCode.Mouse0))
      BuildAtCurseur();

      if (Input.GetKey(KeyCode.Mouse1))
      MoveCamera();

     MoveCameraAtBound();
	}

    void BuildAtCurseur ()
    {
      RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
            if (hit.collider.tag == "Ground")
              PullingManager.Instance.Build(hit.point + new Vector3 (0,-1 + transform.localScale.y/2,0), typeBuilding.Barrack);
            }  
        }
    }

    void MoveCamera ()
    {
      Camera.main.transform.position += new Vector3(Input.GetAxis("Mouse Y") + Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y") - Input.GetAxis("Mouse X"));
    }

  public void MoveCameraAtBound ()
    {
      Vector3 mousePosition = transform.position;
      RaycastHit hit;
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
          if (hit.collider.tag == "Screen")
              mousePosition =  hit.point;
            }  
      
      Debug.Log(mousePosition);

    //  Camera.main.transform.position += new Vector3(mousePosition.y + mousePosition.x, 0, mousePosition.y - mousePosition.x);
    }
}
