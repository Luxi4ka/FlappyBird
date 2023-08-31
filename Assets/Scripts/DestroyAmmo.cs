using UnityEngine;

public class DestroyAmmo : MonoBehaviour
{
    [SerializeField] private float timeDestroy;
    void Start()
    {
        Destroy(gameObject, timeDestroy);
    }
}
