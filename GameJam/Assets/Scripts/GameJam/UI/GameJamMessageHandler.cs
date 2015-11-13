using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GameJamMessageHandler : NetworkBehaviour
{

	public Text messageHolder;

	public float lerpingTime = 1;
	public float showedTime = 3;

	private Vector3 hidePosition;
	private Vector3 showPosition;

	private float _lerpingTime;

	public void Start() {
		//Gets the show and hide position
		showPosition = transform.localPosition;
		hidePosition = transform.localPosition + Vector3.down * 100;
		transform.localPosition = hidePosition;
		_lerpingTime = 1f / lerpingTime;
	}

	public void Update() {
		
		if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
			receiveMessage("Follow Me!");

		if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
			receiveMessage("Whats This?");

		if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
			receiveMessage("Action!");

		if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
			receiveMessage("My Bad XD");

		if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
			receiveMessage("NO!!!");

		if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
			receiveMessage("Pushing Box");

		if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
			receiveMessage("Broken Wall");

		if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
			receiveMessage("Moving Platform");

		if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
			receiveMessage("Portal");

	}

	public void receiveMessage(string message) {
		messageHolder.text = message;
		StopAllCoroutines();
		transform.localPosition = hidePosition;
		StartCoroutine(showMessage());
	}

	public IEnumerator showMessage() {
		float time = 0;
		while(time < lerpingTime)
		{
			time += Time.deltaTime;
			transform.position = Vector3.Lerp(hidePosition, showPosition, time * _lerpingTime);
			yield return 0;
		}
		transform.position = showPosition;
		yield return new WaitForSeconds(showedTime);
		while (time > 0)
		{
			time -= Time.deltaTime;
			transform.position = Vector3.Lerp(hidePosition, showPosition, time * _lerpingTime);
			yield return 0;
		}
		transform.position = hidePosition;
	}
}
