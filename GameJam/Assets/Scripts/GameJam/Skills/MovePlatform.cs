using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {

	private bool nearPlatform;
	GameObject platform;
	
	void Start () {
	
	}
	

	void Update () {

		ActivatePlatform ();
	
	}

	void OnTriggerEnter(Collider other)
	{
		platform = PlatformManager.FindPlatform (other.gameObject);
		
		if (other.gameObject == platform) {
			nearPlatform = true;
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		
		if (other.gameObject == PlatformManager.FindPlatform(other.gameObject))
		{
			nearPlatform = false;
		}
	}
	
	void ActivatePlatform()
	{
		
		if (Input.GetKeyDown(KeyCode.P) && nearPlatform)
		{
			PlatformManager.ActivePlatform(platform);
		}
	}
}
