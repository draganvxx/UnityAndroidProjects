using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    public Vector3 endPosiition;
    private Vector3 initialPosition;
    public float transitionTime;
    public bool easeInOut;
    // Update is called once per frame
    public void Start()
    {
        initialPosition = transform.localPosition;
        StartCoroutine(PingPong(true));
    }

    public IEnumerator PingPong(bool ping)
    {
        float elapsedTime = 0;
        Vector3 startPosition = ping ? initialPosition : endPosiition;
        Vector3 finishPosition = ping ? endPosiition : initialPosition;

        while (elapsedTime < transitionTime)
        {
            yield return new WaitForEndOfFrame();
            float percentage = elapsedTime / transitionTime;
            transform.localPosition = Vector3.Lerp(startPosition, finishPosition, easeInOut ? EaseInOut(percentage) :percentage);
            elapsedTime += Time.deltaTime;
        }

        StartCoroutine(PingPong(!ping));
    }

    public static float EaseInOut(float time)
    {
        float sqt = time * time;
        return (sqt) / (2 * (sqt - time) + 1);
    }

}
