using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subscriber : MonoBehaviour
{
    public Text collisionText;
    public void WatchAll(int editionNumber)
    {
        Debug.Log(gameObject.name + " watched everything in the edition" + editionNumber);
    }
    public void WatchSport(int editionNumber)
    {
        Debug.Log(gameObject.name + " watched the sport section in the edition" + editionNumber);
    }
    public void WatchNews(int editionNumber)
    {
        Debug.Log(gameObject.name + " watched the news in the edition " + editionNumber);
    }
    public void ZoneEntered()
    {
        collisionText.text = ($"{gameObject.name} has collided with the boundary.");
    }

    public void ZoneExited()
    {
        collisionText.text = ($"{gameObject.name} has left the boundary.");
    }
}
