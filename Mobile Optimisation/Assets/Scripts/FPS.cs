using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public int avgFrameRate;
    public Text frameRateDisplay;

    // Update is called once per frame
    void Update()
    {
        float current = 0;
        current = (int)(1f / Time.unscaledDeltaTime);
        frameRateDisplay.text = $"{current} FPS";
    }
}
