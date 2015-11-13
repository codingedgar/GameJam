using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public partial class GameJamCharacterSetUp : NetworkBehaviour
{
    #region Methods
    
    static public void CameraController(GameObject GO, bool value, GameJamColors color)
    {
        GameJamCharacterCameraController aux = GO.GetComponentInChildren<Camera>().gameObject.AddComponent<GameJamCharacterCameraController>();

        aux.Init(value, color);
    }
    
    #endregion
}
