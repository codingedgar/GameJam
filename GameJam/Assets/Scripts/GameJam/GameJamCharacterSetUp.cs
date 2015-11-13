using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public class GameJamCharacterSetUp : NetworkBehaviour
{


    public override void OnStartLocalPlayer()
    {
        base.OnStartClient();



        activateInputControllers(this.gameObject, isLocalPlayer);
        activateCamera(this.gameObject, isLocalPlayer);
    }

    static public void activateCamera(GameObject chobj, bool value)
    {
        chobj.GetComponentInChildren<Camera>().enabled = value;
    }

    static public void activateInputControllers(GameObject characterObject, bool value)
    {
        characterObject.GetComponent<FirstPersonController>().enabled = value;
    }
}
