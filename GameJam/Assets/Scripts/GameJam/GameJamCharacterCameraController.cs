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


    public void Init(bool activate, GameJamColors color)
    {
        thisCamera = this.GetComponent<Camera>();
        if (activate)
        {
            thisCamera.gameObject.layer = LayerMask.NameToLayer(color.EnumToLayerName());
        }
        else
        {
            thisCamera.enabled = false;
        }
    }


    #endregion
}
