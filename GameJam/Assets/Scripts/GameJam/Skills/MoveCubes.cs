using UnityEngine;
using System.Collections;

public class MoveCubes : MonoBehaviour {

	private bool nearCube;
	GameObject cube;

	void Start () {
	
	}
	

	void Update () {

		ActivateCube ();
	
	}

	void OnTriggerEnter(Collider other)
	{
		cube = CubeManager.FindCube(other.gameObject);
		
		if (other.gameObject == cube)
		{
			nearCube = true;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		
		if (other.gameObject == CubeManager.FindCube(other.gameObject))
		{
			nearCube = false;
			CubeManager.InactiveRigidbody(other.gameObject);
		}
	}
	
	void ActivateCube()
	{
		
		if (Input.GetKeyDown(KeyCode.P) && nearCube)
		{
			CubeManager.ActiveRigidbody(cube);
		}
	}
}
