using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingManager : MonoBehaviour {

public static PullingManager Instance;

    public List<GameObject> listBuilding;

	void Awake () 
    {
		Instance = this;

      foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Building"))
      {
            listBuilding.Add(obj);
      }
	}

    public void Build (Vector3 buildPosition, typeBuilding type) {
      if (listBuilding.Count != 0)
      {
       GameObject newBuilding = listBuilding[0];
       listBuilding.Remove(newBuilding);
       newBuilding.transform.position = buildPosition;
       newBuilding.GetComponent<Building>().type = type;
       newBuilding.GetComponent<Building>().isSpawned = true;
       }
    }
}
