using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public class GameJamCharacterSetUp : NetworkBehaviour
{
    public override void OnStartClient()
    {
        base.OnStartClient();

        SetUp();
    }

    public override void OnStartServer()
    {
        base.OnStartServer();

        SetUp();
    }

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        SetUp();        
    }
    
    public void SetUp()
    {
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
