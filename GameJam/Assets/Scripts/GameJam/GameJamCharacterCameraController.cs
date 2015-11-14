using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class GameJamCharacterCameraController : MonoBehaviour
{
    #region Variables
    Camera thisCamera = null;
    GameJamColors color = GameJamColors.White;
    #endregion
    
    #region Methods


    public void Init(bool isLocalPlayer, GameJamColors color)
    {
        thisCamera = this.GetComponentInChildren<Camera>();
        thisCamera.enabled = isLocalPlayer;
        if (isLocalPlayer)
        {
            setLayerInCamera(color);
        }
        else
        {
            
        }
    }

    void setLayerInCamera(GameJamColors color)
    {
        //int layer;

        //layer = 1 << LayerMask.NameToLayer(color.EnumToLayerName());

        //layer = ~layer;

        thisCamera.cullingMask = color.AllButThisCullingMask();

    }

    #endregion
}
