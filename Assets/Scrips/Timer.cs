using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
   [SerializeField]
    private Text timerText;
    [SerializeField]
    private UnityEvent onSecondPassed;
    [SerializeField]
    private UnityEvent onTimerEnd;
    [SerializeField]
    private string timerAnimationName = "ShowAndDisappear";
    private Animator textAnimator;
    private Coroutine timerCoroutine;
    private void Awake()
    {
        textAnimator = timerText.GetComponent<Animator>();
    }
    public void StartTimer(float duration)
    {
        if (timerCoroutine != null)
        {
            StopCoroutine(timerCoroutine);
        }
        timerCoroutine = StartCoroutine(TimerRoutine(duration));
    }
    
 private IEnumerator TimerRoutine(float duration)
    {
        float remainingTime = duration;
        while (remainingTime > 0)
        {
            timerText.text = remainingTime.ToString("F0");
            textAnimator.Play(timerAnimationName, 0, 0);
            onSecondPassed.Invoke();
            yield return new WaitForSeconds(1f);
            remainingTime--;
        }
        timerText.text = "0";
        onTimerEnd.Invoke();
    }
    public void StopTimer()
    {
        if (timerCoroutine != null)
        {
            StopCoroutine(timerCoroutine);
            timerCoroutine = null;
        }
        timerText.text = "0";
        textAnimator.Play("Hide");
    }
}
