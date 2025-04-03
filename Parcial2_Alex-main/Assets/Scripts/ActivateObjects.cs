using UnityEngine;

public class ActivateObjects : MonoBehaviour
{
    [SerializeField]

    private GameObject[] objectToActivate;

    private void OnEnable()
    {
        ActivateAllObjects();
    }
    private void ActivateAllObjects()
    {
        foreach (GameObject obj in objectToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }
}
