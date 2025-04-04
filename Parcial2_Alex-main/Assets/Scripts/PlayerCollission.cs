using UnityEngine;
using UnityEngine.Events;

public class PlayerCollission : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onPlayerLose;
    [SerializeField]
    private UnityEvent<Transform> onObstacleDestroy;
    [SerializeField]
    private UnityEvent<Transform> OnCollisionDie;
    [SerializeField]
    private UnityEvent onCoinCollected;
    private Dash dash;



    private void Start()
    {
        dash = GetComponent<Dash>();   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            if(dash.IsDashing)
            {
                onObstacleDestroy?.Invoke(transform);
                Destroy(collision.gameObject);
            }
            else
            {
                OnCollisionDie?.Invoke(transform);
                onPlayerLose?.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
           OnCollisionDie?.Invoke(transform);
            onPlayerLose?.Invoke();
        }
        else if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            onCoinCollected?.Invoke();
        }
    }
}
