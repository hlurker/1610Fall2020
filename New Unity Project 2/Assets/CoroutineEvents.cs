using System.Collections;

using UnityEngine;

public class CoroutineEvents : MonoBehaviour
{
    public UnityEvent StartEvent, repeatEvent, endEvent;
    public float holdtime, repeatHoldTime = 0.25f;
    public int counter = 3;

    private IEnumerator Corountine()
    {
        StartEvent.Invoke();

        yield return new WaitForSeconds(holdTime);

        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return new WaitForSeconds(repeatHoldTime);
            counter--;
        }

        yield return new WaitForSeconds(holdTime);
        endEvent.Invoke();
    }
}
