using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PortalManager : MonoBehaviour {

    private List<GameObject> portalsElement;
    public static PortalManager instance;

    void Awake() {

        instance = this;
        portalsElement = new List<GameObject>();

    }

	void Start () {
	


	}
	
	void Update () {
	
	}

    public static void AddPortals(GameObject portal)
    {

        instance.portalsElement.Add(portal);

    }

    public static void ActivatePortal(GameObject portalEnter, GameObject userPortal){

        int portalOutId = portalEnter.GetComponent<Portals>().portalOut;
        GameObject portalOut = instance.portalsElement.Find(x => x.GetComponent<Portals>().portalOut == portalOutId);
        userPortal.transform.position = portalOut.transform.position;
    }
}
