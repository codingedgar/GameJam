using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class CubeManager : NetworkBehaviour {

    private List<GameObject> cubeElements;
    public static CubeManager instance;

    void Awake() {

        instance = this;
        cubeElements = new List<GameObject>();
    }

    void Start () {

        
	
	}
	
	
	void Update () {
	
	}

    public static void AddCube(GameObject cube)
    {

        instance.cubeElements.Add(cube);

    }

    public static GameObject FindCube(GameObject cube)
    {

		GameObject cubeFind = instance.cubeElements.Find(x => x == cube);

		return cubeFind;
    }

	public static void ActiveRigidbody(GameObject cube){


		Rigidbody cubeRb = cube.GetComponent<Rigidbody> ();
		cubeRb.isKinematic = false;

	}

	public static void InactiveRigidbody(GameObject cube){
		
		Rigidbody cubeRb = cube.GetComponent<Rigidbody> ();

		//cubeRb.isKinematic = true;

        cube.GetComponent<NetworkTransform>().rigidbody3D.isKinematic = true;

	}
}
