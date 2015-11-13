using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public class GameJamCharacterSetUp : NetworkBehaviour
{

    public override void OnStartServer()
    {
        base.OnStartServer();

        setUp();

    }

    public override void OnStartClient()
    {
        base.OnStartClient();

        setUp();
    }

    public void setUp()
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
