using UnityEngine;
using System.Collections;
//using UnityEngine.Networking;

public class Cubes : MonoBehaviour
{


    void Start()
    {

        CubeManager.AddCube(this.gameObject);
    }

    //[Command]
    //public void Mueveme()
    //{

    //}
}
