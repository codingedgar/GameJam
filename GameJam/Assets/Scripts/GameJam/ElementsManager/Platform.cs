using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {


	void Start () {

		PlatformManager.AddPlatform(this.gameObject);

    }
	
	void Update () {
	
	}
}
