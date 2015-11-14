using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GameJamMessageController : MonoBehaviour
{

    [SerializeField]
    int ID = 0;

	int currentValue;

    public float lerpingTime = 1;
    public float showedTime = 3;

	public Image icon;

	public string[] iconNames;

    public Text messageHolder;
    private Vector3 hidePosition;
    private Vector3 showPosition;

    private float _lerpingTime;

    private GameJamMessageServer _gms;

	private Sprite[] icons;

    public void Start()
    {
        //Gets the show and hide position
        showPosition = transform.localPosition + Vector3.up * 120;
        hidePosition = transform.localPosition;
        transform.localPosition = hidePosition;
        _lerpingTime = 1f / lerpingTime;

		icons = new Sprite[iconNames.Length];
		for (int i = 0; i < icons.Length; i++)
			icons[i] = Resources.Load<Sprite>("iCONS/" + iconNames[i]);
    }

    public void Setup(GameJamMessageServer gms)
    {
        _gms = gms;
    }

    void Update()
    {
        if (_gms == null)
            _gms = FindObjectOfType<GameJamMessageServer>();
        if (this.ID == 1 && _gms.updateRed != currentValue)
            checkForSpecificMessage(_gms.updateRed);
        if (this.ID == 2 && _gms.updateBlue != currentValue)
            checkForSpecificMessage(_gms.updateBlue);
        if (this.ID == 3 && _gms.updateGreen != currentValue)
            checkForSpecificMessage(_gms.updateGreen);
        if (this.ID == 4 && _gms.updateYellow != currentValue)
            checkForSpecificMessage(_gms.updateYellow);
    }

    void checkForSpecificMessage(int messageValue)
    {
		icon.sprite = icons[messageValue];
        switch (messageValue)
        {
            case 1:
                RpcReceiveMessage("Follow Me!");
                break;
            case 2:
                RpcReceiveMessage("Whats this?");
                break;
            case 3:
                RpcReceiveMessage("Action!");
                break;
            case 4:
                RpcReceiveMessage("My Bad XD");
                break;
            case 5:
                RpcReceiveMessage("NO!");
                break;
            case 6:
                RpcReceiveMessage("Pushing Box");
                break;
            case 7:
                RpcReceiveMessage("Broken Wall");
                break;
            case 8:
                RpcReceiveMessage("Moving Platform");
                break;
            case 9:
                RpcReceiveMessage("Portal");
                break;
            default:
                break;
        }
		currentValue = messageValue;
        //messageValue = 0;
    }

    //[ClientRpc]
    public void RpcReceiveMessage(string message)
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

		if (this.ID == 1)
			_gms.updateRed = 0;
		if (this.ID == 2)
			_gms.updateBlue = 0;
		if (this.ID == 3)
			_gms.updateGreen = 0;
		if (this.ID == 4)
			_gms.updateYellow = 0;
		currentValue = 0;
	}
}
