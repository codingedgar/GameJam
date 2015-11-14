﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class GameJamMessageClient : NetworkBehaviour {

	//public delegate void MessageBoxDelegate(int message, int color);

	//[SyncVar]
	//public GameJamColors m_color = GameJamColors.Red;
	[SyncVar]
	public int m_color;

	//[SyncEvent]
	//public event MessageBoxDelegate EventSendMessageDelegate;

	public GameJamMessageServer server;

	[ClientCallback]
	void Start() {
		server = FindObjectOfType<GameJamMessageServer>();//.updateColor(message, m_color);
	}

	[Command]
	public void CmdSendBoxMessage(int message)
	{
		//Debug.Log(message + " " + m_color);
		//EventSendMessageDelegate(message, (int)m_color);
		server.updateColor(message, m_color);
	}

	[ClientCallback]
	void Update() {
		if (!isLocalPlayer)
			return;

		if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
			CmdSendBoxMessage(0);
		if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
			CmdSendBoxMessage(1);
		if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
			CmdSendBoxMessage(2);
		if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
			CmdSendBoxMessage(3);
		if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
			CmdSendBoxMessage(4);
		if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
			CmdSendBoxMessage(5);
		if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
			CmdSendBoxMessage(6);
		if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
			CmdSendBoxMessage(7);
		if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
			CmdSendBoxMessage(8);
		if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
			CmdSendBoxMessage(9);
	}
}
