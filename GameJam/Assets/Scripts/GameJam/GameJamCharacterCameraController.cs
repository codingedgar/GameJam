using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class GameJamCharacterCameraController : MonoBehaviour
{
    #region Variables
    Camera thisCamera = null;
    #endregion
    
    #region Methods


    public void Init(bool isLocalPlayer, GameJamColors color)
    {
        thisCamera = this.GetComponentInChildren<Camera>();
        thisCamera.enabled = isLocalPlayer;
        if (isLocalPlayer)
        {
            //thisCamera.gameObject.layer = LayerMask.NameToLayer(color.EnumToLayerName());
        }
        else
        {
            //thisCamera.enabled = false;
        }
    }


    #endregion
}
