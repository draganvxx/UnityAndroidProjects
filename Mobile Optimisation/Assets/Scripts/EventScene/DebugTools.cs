using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTools : MonoBehaviour
{
    public void PrintPlayerAge()
    {
        Debug.Log(PlayerManager.GetInstance.playerAge);
    }

    public void PrintPlayerName()
    {
        Debug.Log("Player Name is: " + PlayerManager.GetInstance.playerName);
    }
}
