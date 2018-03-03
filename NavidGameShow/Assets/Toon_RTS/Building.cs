using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

public typeBuilding type;
public bool isSpawned = false;
	
	// Update is called once per frame
	void Update () {
		if (isSpawned)
        {
        isSpawned = false;
        TransformType();
        }
        
	}

    void TransformType ()
    {
       switch (type) {
       case typeBuilding.Barrack:
           name = type.ToString();
       break;
       }
    }

    public void Dead ()
    {
    transform.position = new Vector3 (999,999,999);
    PullingManager.Instance.listBuilding.Add(gameObject);
    }
}
