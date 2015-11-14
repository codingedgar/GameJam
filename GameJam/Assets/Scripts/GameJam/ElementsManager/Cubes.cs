using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {


	void Start () {

        CubeManager.AddCube(this.gameObject);
	
	}
	

	void Update () {
	
	}
}
