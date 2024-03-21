using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public int Points;

    public GUIStyle PointStyle;

    private void OnGUI()
    {
        GUI.Label(new Rect(10,10,100,100),Points.ToString(),PointStyle);
    }
}