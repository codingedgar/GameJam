﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformManager : MonoBehaviour {

	private List<GameObject> platformMovable;
	public static PlatformManager instance;
	public bool up;
    void Awake() {

 		instance = this;
		platformMovable = new List<GameObject>();

    }

	void Start () {
	


	}
	
	void Update () {
	
	}

    public static void AddPlatform(GameObject platform)
    {

		instance.platformMovable.Add(platform);

    }

	public static GameObject FindPlatform(GameObject platform){

		GameObject platformFind = instance.platformMovable.Find(x => x == platform);

		return platformFind;
    }

	public static void ActivePlatform(GameObject platform) {

		instance.up = platform.GetComponent<Platform> ().up;
		GameObject pointInit = platform.GetComponent<Platform> ().initPoint;
		GameObject pointEnd = platform.GetComponent<Platform> ().endPoint;

		if (!instance.up) {
			platform.transform.position = Vector3.Lerp (platform.transform.position, pointEnd.transform.position, 0.5f);
			platform.GetComponent<Platform> ().up = true;
		} else {
			platform.transform.position = Vector3.Lerp (platform.transform.position, pointInit.transform.position, 0.5f);
			platform.GetComponent<Platform> ().up = false;
		}

    }
	
}