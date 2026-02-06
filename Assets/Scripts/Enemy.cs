using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int enemyHealth = 3;
    [SerializeField] GameObject explosionVFX;
    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        if (enemyHealth <= 0)
        {
            //enemy obects that collide with the player lasers
            Destroy(this.gameObject);
            Instantiate(explosionVFX, transform.position, Quaternion.identity);
        }
        enemyHealth--;
    }
}
