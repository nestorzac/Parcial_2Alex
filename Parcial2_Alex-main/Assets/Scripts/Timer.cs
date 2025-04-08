using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   [SerializeField]
   private Text timerText;
   [SerializeField]
   private UnityEvent onSecondPassed;
   private int currentSeconds;

   public void StartTimer(int starSeconds)
   {
    currentSeconds = starSeconds;
    SetTimer();
   }
   private void SetTimer()
   {
    onSecondPassed?.Invoke();
    currentSeconds--;
    timerText.text = currentSeconds.ToString();
    if (currentSeconds > 0)
    {
        Invoke("SetTimer", 1f);
    }
   }

}
