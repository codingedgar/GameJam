using UnityEngine;
using System.Collections;

public class ActiveButon : MonoBehaviour {

	public GameObject wall;
	bool nearPlayer;
	void Start () {
	
	}
	

	void Update () {
	
		ActivateButon();
	}

	void OnTriggerEnter(Collider other)
	{

			nearPlayer = true;
	}
	
	void OnTriggerExit(Collider other)
	{

			nearPlayer = false;

	}

	void ActivateButon()
	{
		
		if (Input.GetKeyDown(KeyCode.P) && nearPlayer)
		{
			wall.SetActive(false);
		}
	}
}
