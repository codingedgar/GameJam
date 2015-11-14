using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GameJamMessageController : MonoBehaviour {

	public int id;

	public float lerpingTime = 1;
	public float showedTime = 3;

	public Text messageHolder;
	private Vector3 hidePosition;
	private Vector3 showPosition;

	private float _lerpingTime;

	private GameJamMessageServer _gms;

	public void Start()
	{
		//Gets the show and hide position
		showPosition = transform.localPosition + Vector3.up * 100;
		hidePosition = transform.localPosition;
		transform.localPosition = hidePosition;
		_lerpingTime = 1f / lerpingTime;
	}

	public void Setup(GameJamMessageServer gms) {
		_gms = gms;
	}

	void Update() {
		if (id == 0 && _gms.updateRed > 0)
			checkForSpecificMessage(ref _gms.updateRed);
		if (id == 1 && _gms.updateBlue > 0)
			checkForSpecificMessage(ref _gms.updateBlue);
		if (id == 2 && _gms.updateGreen > 0)
			checkForSpecificMessage(ref _gms.updateGreen);
		if (id == 3 && _gms.updateYellow > 0)
			checkForSpecificMessage(ref _gms.updateYellow);
	}

	void checkForSpecificMessage(ref int messageValue)
	{
		switch (messageValue)
		{
			case 1:
				RpcReceiveMessage("Follow Me!");
				break;
			case 2:
				RpcReceiveMessage("Whats this?");
				break;
			case 3:
				RpcReceiveMessage("Action!");
				break;
			case 4:
				RpcReceiveMessage("My Bad XD");
				break;
			case 5:
				RpcReceiveMessage("NO!");
				break;
			case 6:
				RpcReceiveMessage("Pushing Box");
				break;
			case 7:
				RpcReceiveMessage("Broken Wall");
				break;
			case 8:
				RpcReceiveMessage("Moving Platform");
				break;
			case 9:
				RpcReceiveMessage("Portal");
				break;
			default:
				break;
		}
		messageValue = 0;
	}

	//[ClientRpc]
	public void RpcReceiveMessage(string message)
	{
		messageHolder.text = message;
		StopAllCoroutines();
		transform.localPosition = hidePosition;
		StartCoroutine(showMessage());
	}

	public IEnumerator showMessage()
	{
		float time = 0;
		while (time < lerpingTime)
		{
			time += Time.deltaTime;
			transform.localPosition = Vector3.Lerp(hidePosition, showPosition, time * _lerpingTime);
			yield return 0;
		}
		transform.localPosition = showPosition;
		yield return new WaitForSeconds(showedTime);
		while (time > 0)
		{
			time -= Time.deltaTime;
			transform.localPosition = Vector3.Lerp(hidePosition, showPosition, time * _lerpingTime);
			yield return 0;
		}
		transform.localPosition = hidePosition;
	}
}
