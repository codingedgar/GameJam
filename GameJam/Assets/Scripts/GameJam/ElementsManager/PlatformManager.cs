using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformManager : MonoBehaviour {

	private List<GameObject> platformMovable;
	public static PlatformManager instance;

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

		Debug.Log ("Active plataforma");

    }

}
