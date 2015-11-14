using UnityEngine;
using System.Collections;

public class DestroyWall : MonoBehaviour {

    private bool nearWall;
    GameObject wall;

	void Start () {


	}
	

	void Update () {

        ActivateBreak();

    }

    void OnTriggerEnter(Collider other)
    {
        wall = BrokenWallManager.FindBrokenWall(other.gameObject);

        if (other.gameObject == wall)
        {
            nearWall = true;
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject == BrokenWallManager.FindBrokenWall(other.gameObject))
        {
            nearWall = false;
        }
    }

    void ActivateBreak()
    {

        if (Input.GetKeyDown(KeyCode.P) && nearWall)
        {
            BrokenWallManager.BreakWall(wall);
        }
    }
}
