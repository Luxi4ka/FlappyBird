using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] private float force;
    private Rigidbody2D rgBody;

    [SerializeField] private float timeDestroy;

    [SerializeField] private GameObject enemy;
    private void Start()
    {
        AmmoDirection();
        DestroyAmmo();
    }
    private void AmmoDirection()
    {
        rgBody = GetComponent<Rigidbody2D>();
        rgBody.AddForce(transform.right * force);
    }
    private void DestroyAmmo()
    {
        Destroy(gameObject, timeDestroy);
    }
   
}
