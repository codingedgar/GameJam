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

    public static int AllButThisCullingMask(this GameJamColors color)
    {
        int layerMask = 0;

        GameJamColors[] arrayMalandro;

        arrayMalandro = Enum.GetValues(typeof(GameJamColors)).Cast<GameJamColors>().ToArray();
        
        for (int i = arrayMalandro.Length - 1; i >= 0; i--)
        {
            if (arrayMalandro[i] != color)
            layerMask = (layerMask | arrayMalandro[i].enumToLayerMask());
                
        }
        
        return layerMask = ~layerMask;
    }

    public static int enumToLayerMask(this GameJamColors color)
    {
        int layer;

        layer = 1 << LayerMask.NameToLayer(color.EnumToLayerName());

        return layer;
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
