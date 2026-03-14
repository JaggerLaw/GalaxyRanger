using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    GameSceneManager gameSceneManager;
    [SerializeField] ParticleSystem explosionVFX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // gameSceneManager = GetComponent<GameSceneManager>();
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        gameSceneManager.ReloadLevel();
        Instantiate(explosionVFX, transform.position, Quaternion.identity);
        if (!explosionVFX.isPlaying)
        {
            explosionVFX.Play();
        } else
        {
            explosionVFX.Stop();
        }

        Destroy(gameObject);

    }
}
