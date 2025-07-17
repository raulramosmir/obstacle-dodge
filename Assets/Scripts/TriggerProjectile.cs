using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;
    [SerializeField] GameObject projectile5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (projectile1 != null)
            {
                projectile1.SetActive(true);
            }
            if (projectile2 != null)
            {
                projectile2.SetActive(true);
            }
            if (projectile3 != null)
            {
                projectile3.SetActive(true);
            }
            if (projectile4 != null)
            {
                projectile4.SetActive(true);
            }
            if (projectile5 != null)
            {
                projectile5.SetActive(true);
            }
            
            Destroy(gameObject);
        }
    }
}
