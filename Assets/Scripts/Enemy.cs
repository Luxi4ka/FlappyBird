using UnityEngine;

public class Enemy : MonoBehaviour
{
    //����� ������ ������ 5 ������

    [SerializeField] private float speed;
    [SerializeField] private Transform target;

   
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }   
}
