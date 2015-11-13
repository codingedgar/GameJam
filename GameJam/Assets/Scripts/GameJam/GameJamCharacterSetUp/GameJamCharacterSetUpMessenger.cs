using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public partial class GameJamCharacterSetUp : NetworkBehaviour
{

	#region Methods

	void addMessageClient() {
		gameObject.AddComponent<GameJamMessageClient>();
		GameJamMessageClient gameJamMessageClient = GetComponent<GameJamMessageClient>();
		gameJamMessageClient.m_color = m_Color == Color.red ? GameJamColors.Red : GameJamColors.Blue;
	}
	
    #endregion
}
