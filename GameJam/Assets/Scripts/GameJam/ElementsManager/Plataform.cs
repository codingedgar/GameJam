using UnityEngine;
using System.Collections;

public class Plataform : MonoBehaviour {


	void Start () {

        BrokenWallManager.AddBrokenWall(this.gameObject);

    }
	
	void Update () {
	
	}
}
