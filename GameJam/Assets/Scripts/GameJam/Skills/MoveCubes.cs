using UnityEngine;
using System.Collections;

public class MoveCubes : MonoBehaviour {

	private bool nearCube;
	GameObject cube;

	void Start () {
	
	}
	

	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		cube = BrokenWallManager.FindBrokenWall(other.gameObject);
		
		if (other.gameObject == cube)
		{
			nearCube = true;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		
		if (other.gameObject == BrokenWallManager.FindBrokenWall(other.gameObject))
		{
			nearCube = false;
		}
	}
	
	void ActivateCube()
	{
		
		if (Input.GetKeyDown(KeyCode.P) && nearCube)
		{
			CubeManager.MoveCube(cube);
		}
	}
}
