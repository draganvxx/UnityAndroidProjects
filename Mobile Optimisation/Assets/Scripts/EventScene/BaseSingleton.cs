using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BaseSingleton<T> : MonoBehaviour where T:MonoBehaviour
{
    public static T instance;

    public static T GetInstance
    {
        get
        {
            return instance;
        }
        set
        {
            if (!instance)
            {
                instance = value;
                DontDestroyOnLoad(value);
            }
            else if (instance != value)
            {
                Destroy(value);
            }
        }
    }

    public virtual void Awake()
    {
        GetInstance = GetComponent<T>();
    }
}
