using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public partial class GameJamCharacterSetUp : NetworkBehaviour
{
    #region Methods
    
    static public void CameraController(GameObject GO, bool isLocalPlayer, GameJamColors color)
    {
        GameJamCharacterCameraController aux = null;

        aux = GO.GetComponent<GameJamCharacterCameraController>();

        if (!aux) aux = GO.gameObject.AddComponent<GameJamCharacterCameraController>();

        aux.Init(isLocalPlayer, color);
    }
    
    #endregion
}
