using UnityEngine;
using System.Collections;

public class Portals : MonoBehaviour {

    public int portalId;

	void Start () {

        PortalManager.AddPortals(this.gameObject);

	}
	
	void Update () {
	
	}

    void OnTriggerEnter(Collider col) {

        Debug.Log("toque");
        PortalManager.ActivatePortal(this.gameObject, col.gameObject);

    }
}
