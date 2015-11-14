﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeManager : MonoBehaviour {

    private List<GameObject> cubeElements;
    public static CubeManager instance;

    void Awake() {

        instance = this;
        cubeElements = new List<GameObject>();
    }

    void Start () {

        
	
	}
	
	
	void Update () {
	
	}

    public static void AddCube(GameObject cube)
    {

        instance.cubeElements.Add(cube);

    }

    public static void MoveCube(GameObject cubeSelect)
    {

        GameObject portalFind = instance.cubeElements.Find(x => x == cubeSelect);
    }

}
