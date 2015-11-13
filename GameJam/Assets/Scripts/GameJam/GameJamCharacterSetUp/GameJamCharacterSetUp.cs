﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

public partial class GameJamCharacterSetUp : NetworkBehaviour
{

    #region Variables

    public GameObject m_Crown;

    [Header("Network")]
    [Space]

    [SyncVar]
    public GameJamColors gjColor;

    [SyncVar]
    public Color m_Color;

    [SyncVar]
    public string m_PlayerName;

    //this is the player number in all of the players
    [SyncVar]
    public int m_PlayerNumber;

    //This is the local ID when more than 1 player per client
    [SyncVar]
    public int m_LocalID;

    [SyncVar]
    public bool m_IsReady = false;

    //This allow to know if the crown must be displayed or not
    protected bool m_isLeader = false;
    #endregion

    #region Methods

    public override void OnStartClient()
    {
        base.OnStartClient();

        SetUp();
    }

    public override void OnStartServer()
    {
        base.OnStartServer();

        SetUp();
    }

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();

        SetUp();
    }

    public void SetUp()
    {
        SetUpInit();
        if (!isServer)
        {
            SetUpIfClient();
        }
    }

    void SetUpInit()
    {
        activateInputControllers(this.gameObject, isLocalPlayer);
        activateMessageHandler();
        CameraController(this.gameObject, isLocalPlayer, GameJamColors.Blue);
        this.gameObject.AddComponent<Teleport>();

    }

    void SetUpIfClient()
    {
        GameJamGameManager.AddCharacter(gameObject, m_PlayerNumber, m_Color, m_PlayerName, m_LocalID);
    }

    static public void activateInputControllers(GameObject characterObject, bool value)
    {
        characterObject.GetComponent<FirstPersonController>().enabled = value;
    }

    public void activateMessageHandler()
    {
        Messenger.Broadcast<Color>("activateMessageHandler", m_Color);
    }
    #endregion
}
