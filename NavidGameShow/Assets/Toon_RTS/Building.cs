using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {

public typeBuilding type;
public bool isSpawned = false;
public List<Mesh> listMesh;
public List<Texture> listTexture;

  MeshFilter meshF;
  MeshRenderer meshR;
	
    void Awake ()
    {
       meshF = GetComponent<MeshFilter>();
       meshR = GetComponent<MeshRenderer>();
    }
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
           meshF.mesh = listMesh[0];
       //   Shader= listTexture[0];
       break;
       }
    }

    public void Dead ()
    {
    transform.position = new Vector3 (999,999,999);
    PullingManager.Instance.listBuilding.Add(gameObject);
    }
}
