using UnityEngine;

public class AmmoDirection : MonoBehaviour
{
    [SerializeField] private float force;
    private Rigidbody2D rgBody;
    private void Start()
    {
        rgBody = GetComponent<Rigidbody2D>();
        rgBody.AddForce(transform.right * force);
    }
   
}
