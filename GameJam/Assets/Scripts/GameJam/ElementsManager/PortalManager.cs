using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class PortalManager : MonoBehaviour
{

    private List<GameObject> portalsElement;
    public static PortalManager instance;

    void Awake()
    {

        instance = this;
        portalsElement = new List<GameObject>();

    }

    void Start()
    {



    }

    void Update()
    {

    }

    public static void AddPortals(GameObject portal)
    {

        instance.portalsElement.Add(portal);

    }

    public static void ActivatePortal(GameObject portalEnter, GameObject userPortal)
    {

        int portalOutId = portalEnter.GetComponent<Portals>().portalOut;
        GameObject portalOut = instance.portalsElement.Find(x => x.GetComponent<Portals>().portalIn == portalOutId);
        userPortal.transform.position = portalOut.transform.position;

        transporarATodos(portalOut.transform.position);
    }

    static void transporarATodos(Vector3 asdf)
    {
        var todos = FindObjectsOfType<GameJamCharacterSetUp>();

        for (int i = todos.Length - 1; i >= 0; i--)
        {
            todos[i].gameObject.GetComponent<NetworkTransform>().rigidbody3D.transform.position = asdf;
        }
    }


    public static GameObject FindPortal(GameObject portal)
    {

        GameObject portalFind = instance.portalsElement.Find(x => x == portal);

        return portalFind;
    }
}
