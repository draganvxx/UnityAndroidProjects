using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    public List<GameObject> models = new List<GameObject>();
    public int currentlyDisplayedModelIndex;

    public void ChangeModel(int newModelIndex)
    {
        models[currentlyDisplayedModelIndex].SetActive(false);
        models[newModelIndex].SetActive(true);

        currentlyDisplayedModelIndex = newModelIndex;
    }

    public void Next()
    {
        int nextIndex = currentlyDisplayedModelIndex + 1;

        if (nextIndex >= models.Count)
        {
            nextIndex = 0;
        }

        ChangeModel(nextIndex);
    }

    public void Previous()
    {
        int prevIndex = currentlyDisplayedModelIndex - 1;

        if (prevIndex < 0)
        {
            prevIndex = models.Count - 1;
        }

        ChangeModel(prevIndex);
    }
}
