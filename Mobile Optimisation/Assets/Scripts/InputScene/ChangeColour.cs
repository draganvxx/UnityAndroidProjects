using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColour : MonoBehaviour
{
    public Image image;

    public void SetColourWithHexa(string hexaColour)
    {
        Color colour = new Color();
        ColorUtility.TryParseHtmlString(hexaColour, out colour);
        image.color = colour;
    }
}
