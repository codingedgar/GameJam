using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public partial class GameJamCharacterSetUp : NetworkBehaviour
{

	#region Methods

	void addMessageClient()
	{
		GameJamMessageServer gms = FindObjectOfType<GameJamMessageServer>();
		gms.Setup();
		GameJamMessageClient gameJamMessageClient = GetComponent<GameJamMessageClient>();
		gameJamMessageClient.m_color = (int)gjColor;
		gameJamMessageClient._gms = gms;
		GameJamMessageController[] gmcs = FindObjectsOfType<GameJamMessageController>();
		foreach (GameJamMessageController gmc in gmcs)
			gmc.Setup(gms);
	}

	#endregion
}
