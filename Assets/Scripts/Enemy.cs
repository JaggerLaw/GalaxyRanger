using UnityEngine;

public class Enemy : MonoBehaviour
{
    int enemyHealth = 100;
    [SerializeField] GameObject explosionVFX;
    void OnParticleCollision(GameObject other)
    {
        if(enemyHealth <= 0)
        {    
            //enemy obects that collide with the player lasers
            Destroy(this.gameObject);
            Instantiate(explosionVFX, transform.position, Quaternion.identity);
        }
        enemyHealth -= 10;
    }
}
