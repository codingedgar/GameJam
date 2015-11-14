using UnityEngine;
using System.Collections;

public class BrokenWall : MonoBehaviour {


	void Start () {

        BrokenWallManager.AddBrokenWall(this.gameObject);

    }
	
	void Update () {
	
	}
}
