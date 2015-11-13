using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GameJamMessageController : NetworkBehaviour {

	public float lerpingTime = 1;
	public float showedTime = 3;

	public Text messageHolder;
	private Vector3 hidePosition;
	private Vector3 showPosition;

	private float _lerpingTime;
	
	public void Start()
	{
		//Gets the show and hide position
		showPosition = transform.localPosition + Vector3.up * 100;
		hidePosition = transform.localPosition;
		transform.localPosition = hidePosition;
		_lerpingTime = 1f / lerpingTime;
	}

	[ClientRpc]
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
