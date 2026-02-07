using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int enemyHealth = 3;
    [SerializeField] GameObject explosionVFX;
    [SerializeField] int scoreValue = 10;

    Scoreboard scoreboard;

    void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }
    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        if (enemyHealth <= 0)
        {
            //enemy obects that collide with the player lasers
            scoreboard.IncreaseScore(scoreValue);
            Destroy(this.gameObject);
            Instantiate(explosionVFX, transform.position, Quaternion.identity);
        }
        enemyHealth--;
    }
}
