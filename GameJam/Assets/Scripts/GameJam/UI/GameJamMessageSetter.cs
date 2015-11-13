using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameJamMessageSetter : MonoBehaviour {

	/// <summary>
	/// 0 - Red
	/// 1 - Blue
	/// 2 - Green
	/// 3 - Yellow
	/// </summary>
	public GameJamMessageHandler[] messageHandlersArray;

	void Start() {
		Messenger.AddListener<Color>("activateMessageHandler", activateMessageHandler);
	}

	public void activateMessageHandler(Color c) {
		if (c == Color.red)
			messageHandlersArray[0].enabled = true;
		if (c == Color.blue)
			messageHandlersArray[1].enabled = true;
		if (c == Color.green)
			messageHandlersArray[2].enabled = true;
		if (c == Color.yellow)
			messageHandlersArray[3].enabled = true;
	}

}
