using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject ammo;
    [SerializeField] private float timeToDestroy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(ammo, transform.position,transform.rotation);
        }
    }
   
}
