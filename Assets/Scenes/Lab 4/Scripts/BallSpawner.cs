using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject[] balls;
    public Transform spawnPoint;
    public float cooldown = .2f;
    bool canSpawn = true;

    void Start()
    {
        Spawn();
    }

    void OnTriggerExit(Collider other)
    {
        if (canSpawn)
            Spawn();
    }

    void Spawn()
    {
        Instantiate(balls[Random.Range(0, balls.Length)], spawnPoint.position, spawnPoint.rotation);
        canSpawn = false;
        Invoke("SpawnCooldown", cooldown);
    }

    void SpawnCooldown()
    {
        canSpawn = true;
    }
}
