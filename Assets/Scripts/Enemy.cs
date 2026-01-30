using UnityEngine;

public class Enemy : MonoBehaviour
{
    int enemyHealth = 100;
    void OnParticleCollision(GameObject other)
    {
        if(enemyHealth <= 0)
        {    
            //enemy obects that collide with the player lasers
            Destroy(this.gameObject);
        }
        enemyHealth -= 10;
    }
}
