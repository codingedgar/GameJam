using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GameJamMessageHandler2 : NetworkBehaviour
{
    public Text messageHolder;

    public float lerpingTime = 1;
    public float showedTime = 3;

    private Vector3 hidePosition;
    private Vector3 showPosition;

    private float _lerpingTime;

    public void Start()
    {
        //Gets the show and hide position
        showPosition = transform.localPosition + Vector3.up * 100;
        hidePosition = transform.localPosition;
        transform.localPosition = hidePosition;
        _lerpingTime = 1f / lerpingTime;
    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            sendMessage("Follow Me!");

        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            sendMessage("Whats This?");

        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            sendMessage("Action!");

        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
            sendMessage("My Bad XD");

        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
            sendMessage("NO!!!");

        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
            sendMessage("Pushing Box");

        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
            sendMessage("Broken Wall");

        if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
            sendMessage("Moving Platform");

        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
            sendMessage("Portal");

    }

    

    public void sendMessage(string message)
    {
        if (isClient)
        {
            clientSideMessage(message);
        }
        else
        {
            serverSideMessage(message);
        }
    }
    
    private void clientSideMessage(string message)
    {

    }

    private void serverSideMessage(string message)
    {
        RpcClientReceiveMessage(message);
    }

    [ClientRpc]
    private void RpcClientReceiveMessage(string message)
    {
        receiveMessage(message);
    }
    
    private void serverReceiveMessage(string message)
    {
        receiveMessage(message);
    }

    
    public void receiveMessage(string message)
    {
        messageHolder.text = message;
        StopAllCoroutines();
        transform.localPosition = hidePosition;
        StartCoroutine(showMessage());
    }

    public IEnumerator showMessage()
    {
        float time = 0;
        while (time < lerpingTime)
        {
            time += Time.deltaTime;
            transform.localPosition = Vector3.Lerp(hidePosition, showPosition, time * _lerpingTime);
            yield return 0;
        }
        transform.localPosition = showPosition;
        yield return new WaitForSeconds(showedTime);
        while (time > 0)
        {
            time -= Time.deltaTime;
            transform.localPosition = Vector3.Lerp(hidePosition, showPosition, time * _lerpingTime);
            yield return 0;
        }
        transform.localPosition = hidePosition;
    }
}
