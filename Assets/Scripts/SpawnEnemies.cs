using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    private void Start()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
