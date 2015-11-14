using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class GameJamCharacterCameraController : MonoBehaviour
{
    #region Variables
    GameJamCharacterSetUp setUp = null;
    Camera thisCamera = null;
    GameJamColors color = GameJamColors.White;
    #endregion

    #region Methods
    
    void Start()
    {
        Init();
    }

    public void Init(bool isLocalPlayer, GameJamColors color)
    {
        thisCamera = this.GetComponentInChildren<Camera>();
        thisCamera.enabled = isLocalPlayer;

        if (isLocalPlayer)
        {
        }
        else
        {

        }
    }

    public void Init()
    {
        setUp = this.GetComponent<GameJamCharacterSetUp>();
        color = setUp.gjColor;
        setLayerInCamera(color);
    }

    void setLayerInCamera(GameJamColors color)
    {
        thisCamera.cullingMask = color.AllButThisCullingMask();
    }

    #endregion
}
