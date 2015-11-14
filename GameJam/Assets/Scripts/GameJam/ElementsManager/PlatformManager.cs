using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformManager : MonoBehaviour {

	private List<GameObject> platformMovable;
	public static PlatformManager instance;
	private Vector3 velocidad;
	public GameObject pointUp;
	public GameObject pointDown;

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

		Debug.Log ("acrtive");

		instance.velocidad = new Vector3 (0f, 7f, 0f);
		platform.transform.position = Vector3.Lerp (platform.transform.position, instance.pointUp.transform.position, 0.5f);

    }
	
}
