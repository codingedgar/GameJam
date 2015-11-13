using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public class GameJamCharacterSetUp : NetworkBehaviour
{

    public override void OnStartClient()
    {
        
    }
    
    public override void OnStartLocalPlayer()
    {
        RpcsetUp();
    }
    
    public override void OnStartServer()
    {

    }
    
    [ClientRpc]
    public void RpcsetUp()
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
