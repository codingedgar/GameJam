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

public static class GameJamColorsExtentions
{

    public static GameJamColors ColorToEnum(Color color)
    {
        if (color == Color.white) { return GameJamColors.White; }
        if (color == Color.red) { return GameJamColors.Red; }
        if (color == Color.blue) { return GameJamColors.Blue; }
        if (color == Color.green) { return GameJamColors.Green; }
        if (color == Color.yellow) { return GameJamColors.Yellow; }
        return GameJamColors.White;

    }

    public static GameJamColors ColorToEnum(this GameJamColors enumerator, Color color)
    {
        return ColorToEnum(color);
    }

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
