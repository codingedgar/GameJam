using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public enum GameJamColors
{
    White,
    Red,
    Blue,
    Green,
    Yellow,
}

public static class GameJamLayerExtentions
{
    
    public static string EnumToLayerName(this GameJamColors enumerator)
    {

        switch (enumerator)
        {
            case GameJamColors.White:
                return "Colors/White";
            case GameJamColors.Red:
                return "Colors/Red";
            case GameJamColors.Blue:
                return "Colors/Blue";
            case GameJamColors.Yellow:
                return "Colors/Yellow";
            case GameJamColors.Green:
                return "Colors/Green";
            default:
                return "";
        }
    }
}
