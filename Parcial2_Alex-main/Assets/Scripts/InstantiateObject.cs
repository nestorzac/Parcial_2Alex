using UnityEngine;

public class InstantiateObject : MonoBehaviour
{

    [SerializeField]
    private GameObject _objectToInstatiate;
    public void InstantiateObjectAtPosition(Transform asset)
    {
        Instantiate(_objectToInstatiate,asset.position, Quaternion.identity);
    }
}
