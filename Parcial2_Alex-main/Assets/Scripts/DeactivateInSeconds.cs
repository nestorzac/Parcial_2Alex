using UnityEngine;
using UnityEngine.Events;

public class DeactiveteInSeconds : MonoBehaviour
{
   [SerializeField]

   private float _secondsToDeactivate = 5f;
   public UnityEvent<GameObject> onDeactivate;

   private void OnEnable()
   {
    Invoke("DesactivateObject", _secondsToDeactivate);
   }

   private void DesactivateObject()
   {
    gameObject.SetActive(false);
   }

   private void OnDisable()
   {
    onDeactivate?.Invoke(gameObject);
   }
}
