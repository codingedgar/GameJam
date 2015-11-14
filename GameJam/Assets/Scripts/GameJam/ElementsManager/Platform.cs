using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public GameObject initPoint;
	public GameObject endPoint;

	public enum direccion{
		up,
		donw,
		left,
		right
	}
	public bool up;

	void Start () {

		PlatformManager.AddPlatform(this.gameObject);

    }
	
	void Update () {
	
	}
}
