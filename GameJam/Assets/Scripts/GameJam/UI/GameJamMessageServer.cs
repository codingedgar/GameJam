using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GameJamMessageServer : NetworkBehaviour
{
	public GameJamMessageController[] messagesReference;

	[SyncVar]
	public int updateRed;

	[SyncVar]
	public int updateBlue;

	[SyncVar]
	public int updateGreen;

	[SyncVar]
	public int updateYellow;

	public void Setup()
	{
		////if (NetworkClient.active)
		////{
		//	//GameJamMessageClient[] clients = FindObjectsOfType<GameJamMessageClient>();
		//	//foreach (GameJamMessageClient client in clients)
		//	//{

		//	//	//client.EventSendMessageDelegate += updateColor;
		//	//	Debug.Log(client.name);
		//	//}
		//	updateValue = new int[messagesReference.Length];
		//	for (int i = 0; i < updateValue.Length; i++)
		//		updateValue[i] = 0;
		////}

		updateRed = 0;
		updateGreen = 0;
		updateBlue = 0;
		updateYellow = 0;
	}

	//[ServerCallback]
	//void Update()
	//{
	//	//for (int i = 0; i < updateValue.Length; i++)
	//	//{
	//	//	checkForSpecificMessage(updateValue[i], messagesReference[i]);
	//	//	if (updateValue[i] != 0)
	//	//		updateValue[i] = 0;
	//	//}
	//}

	//void checkForSpecificMessage(int messageValue, GameJamMessageController messageController)
	//{
	//	switch (messageValue)
	//	{
	//		case 1:
	//			messageController.RpcReceiveMessage("Follow Me!");
	//			break;
	//		case 2:
	//			messageController.RpcReceiveMessage("Whats this?");
	//			break;
	//		case 3:
	//			messageController.RpcReceiveMessage("Action!");
	//			break;
	//		case 4:
	//			messageController.RpcReceiveMessage("My Bad XD");
	//			break;
	//		case 5:
	//			messageController.RpcReceiveMessage("NO!");
	//			break;
	//		case 6:
	//			messageController.RpcReceiveMessage("Pushing Box");
	//			break;
	//		case 7:
	//			messageController.RpcReceiveMessage("Broken Wall");
	//			break;
	//		case 8:
	//			messageController.RpcReceiveMessage("Moving Platform");
	//			break;
	//		case 9:
	//			messageController.RpcReceiveMessage("Portal");
	//			break;
	//		default:
	//			break;
	//	}
	//}

	//public void updateColor(int message, int color)
	//{
	//	if (updateValue != null)
	//		updateValue[color - 1] = message;
	//}
}
