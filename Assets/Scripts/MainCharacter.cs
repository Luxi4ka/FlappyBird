using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody2D rgBody;
    [SerializeField] private float speed;

    private void Start()
    {
        rgBody = GetComponent<Rigidbody2D>();           
    }
    private void Update()
    {
        direction = new Vector2 (Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
    }
    private void FixedUpdate()
    {
        Movement(direction);
    }
    private void Movement(Vector2 direction)
    {
       rgBody.MovePosition ((Vector2)transform.position + (speed * Time.deltaTime * direction));
    }
}
