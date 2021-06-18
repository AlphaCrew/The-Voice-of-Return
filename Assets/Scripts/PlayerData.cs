using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float zoomSpeed;

    public PlayerData (Zoom player)
    {
        zoomSpeed = player.zoomSpeed;
    }
}
