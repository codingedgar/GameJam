using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    private bool stepPortal;
    private GameObject portal;


	void Start () {
	
	}
	

	void Update () {

        ActivateTeleport();

    }

    void OnTriggerEnter(Collider other)
    {
        portal = PortalManager.FindPortal(other.gameObject);

        if (other.gameObject == portal)
        {

            stepPortal = true;
        }
    }
        

    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject == PortalManager.FindPortal(other.gameObject))
        {
            stepPortal = false;
        }
    }

    void ActivateTeleport() {

        if (Input.GetKeyDown(KeyCode.P) && stepPortal)
        {
            PortalManager.ActivatePortal(portal, this.gameObject);
        }
    }
}
