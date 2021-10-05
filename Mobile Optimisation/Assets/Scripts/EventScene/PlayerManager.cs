using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerManager : BaseSingleton<PlayerManager>
{
    //public static PlayerManager GetInstance { get; set; }

    public string playerName;
    public int playerAge;

    public UnityEvent nameUpdated;

    public void SetPlayerName(string name)
    {
        playerName = name;
        nameUpdated?.Invoke();
    }
}
 