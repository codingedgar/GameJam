﻿using UnityEngine;
using System.Collections;

public class Portals : MonoBehaviour {

    public int portalIn;
    public int portalOut;

	void Start () {

        PortalManager.AddPortals(this.gameObject);

	}
	
	void Update () {
	
	}
    /*
    void OnTriggerEnter(Collider col) {

        PortalManager.ActivatePortal(this.gameObject, col.gameObject);

    }*/
}
