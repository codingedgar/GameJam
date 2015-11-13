using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class movimientoRapido : NetworkBehaviour
{

    Vector3 movement;
    public float speed = 6f;
    Rigidbody playerRigidbody;

    private void Start()
    {


    }

    private void Update()
    {
        /*if (!isLocalPlayer)
            return;
            */
        float h = Input.GetAxisRaw("Horizontal1");
        float v = Input.GetAxisRaw("Vertical1");

        Move(h, v);

    }

    void Move(float h, float v)
    {
        playerRigidbody = GetComponent<Rigidbody>();

        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

}
