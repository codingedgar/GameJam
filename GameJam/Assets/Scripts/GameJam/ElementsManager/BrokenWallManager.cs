﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class BrokenWallManager : MonoBehaviour {

    private List<GameObject> brokenWall;
    public static BrokenWallManager instance;

    void Awake() {

        instance = this;
        brokenWall = new List<GameObject>();

    }

	void Start () {
	


	}
	
	void Update () {
	
	}

    public static void AddBrokenWall(GameObject wall)
    {

        instance.brokenWall.Add(wall);

    }

    public static GameObject FindBrokenWall(GameObject wall){

        GameObject wallFind = instance.brokenWall.Find(x => x == wall);

        return wallFind;
    }

    public static void BreakWall(GameObject wall) {

        wall.GetComponent<NetworkTransform>().gameObject.SetActive(false);

    }

}
