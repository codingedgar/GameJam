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
		GameJamMessageClient gameJamMessageClient = GetComponent<GameJamMessageClient>();
		GameJamMessageController[] gmcs = FindObjectsOfType<GameJamMessageController>();
		gameJamMessageClient.m_color = (int)gjColor;
		if (gms != null)
		{
			gms.Setup();
			gameJamMessageClient._gms = gms;
			foreach (GameJamMessageController gmc in gmcs)
				gmc.Setup(gms);
		}
			
	}

	#endregion
}
