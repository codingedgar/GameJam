using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public partial class GameJamCharacterSetUp : NetworkBehaviour
{

    #region Variables
    #endregion

    #region Methods


    partial void SetUpInit()
    {

        CameraController(this.gameObject, isLocalPlayer, GameJamColors.Blue);

        if (isLocalPlayer)
        {

        }
    }

    partial void SetUpIfClient()
    {
        if (isLocalPlayer)
        {

        }
    }


    static public void CameraController(GameObject chobj, bool value, GameJamColors color)
    {
        GameJamCharacterCameraController aux = chobj.GetComponentInChildren<Camera>().gameObject.AddComponent<GameJamCharacterCameraController>();

        aux.Init(value, color);
    }


    #endregion
}
